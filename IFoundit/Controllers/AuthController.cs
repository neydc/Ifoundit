using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    public class AuthController : Controller
    {
        private readonly MkContext context;

        public AuthController(MkContext context)
        {
            this.context = context;
        }
        //Login
        [HttpGet]
        public IActionResult SignIn()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
            }
            return View();
        }
        private Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            if (claim != null)
            {
                var user = context.Usuarios.Where(o => o.Correo == claim.Value).FirstOrDefault();
                return user;
            }
            return null;
        }

        [HttpPost]
        public IActionResult SignIn(string correo, string password)
        {
            if (correo == null || password == null)
            {
                if (string.IsNullOrEmpty(correo))
                {
                    ModelState.AddModelError("Correo", "Correo Requerido");
                }
                if (string.IsNullOrEmpty(password))
                {
                    ModelState.AddModelError("Password", "Contraseña Requerida");
                }
                ViewBag.usuario2 = correo;
                ViewBag.password = password;
                
                return View();
            }
            if (correo != null && password != null)
            {
                var userv = context.Usuarios.Where(o => o.Correo == correo && o.Contrasenia == password).FirstOrDefault();
                if (userv != null)
                {
                    var claims = new List<Claim> {
                             new Claim(ClaimTypes.Name, correo)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    HttpContext.SignInAsync(claimsPrincipal);
                    //return Json(new { dashboard = 1 });
                    return RedirectToAction("misreportes", "reporte");

                }
                else
                {
                    ModelState.AddModelError("Incorrecto", "Usuario y/o Contraseña incorrecta");
                }
            }
            ViewBag.usuario2 = correo;
            ViewBag.password = password; Usuario user = LoggedUser();
           
            return View();
        }
        //Registrarse
        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new Usuario());
        }
        [HttpPost]
        public IActionResult SignUp(Usuario usuario)
        {
            validarDatos(usuario);
            
            if (ModelState.IsValid)
            {
                if (usuario.TieneWhatsapp == 1)
                {
                    usuario.PermitirMostrarWhatsapp = 1;
                }
                else if (usuario.TieneWhatsapp == 0)
                {
                    usuario.PermitirMostrarWhatsapp = 0;
                }
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return RedirectToAction("signin", "auth");
            }

            return View(usuario);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private void validarDatos(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nombre))
            {
                ModelState.AddModelError("Nombre", "Ingrese su nombre y apellido ");
            }
            
            if (string.IsNullOrEmpty(usuario.Celular))
            {
                ModelState.AddModelError("Celular", "Ingrese su número de celular");
            }
            //if (usuario.TieneWhatsapp!=1 || usuario.TieneWhatsapp != 0)
            //{
            //    ModelState.AddModelError("whatsapp", "Eliga una opción");
            //}
            if (usuario.Celular!=null)
            {
               
                if (usuario.Celular.Length !=9)
                {
                    ModelState.AddModelError("Celular2", "Ingrese 9 dígitos");
                }
            }

            if (string.IsNullOrEmpty(usuario.Correo))
            {
                ModelState.AddModelError("Correo", "Ingrese su correo electrónico");
            }
            else if (!Regex.Match(usuario.Correo, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$").Success)
            {
                ModelState.AddModelError("Correo2", "Correo inválido| nombre@dominio.com");
            }

            if (string.IsNullOrEmpty(usuario.Contrasenia))
            {
                ModelState.AddModelError("Contrasenia", "Ingrese su contraseña");
            }

            if (usuario.Contrasenia != null)
            {
                if (usuario.Contrasenia.Length < 4)
                {
                    ModelState.AddModelError("ContraseniaMenorA4", "Mínimo 4 caracteres");
                }
            }

            if (usuario.Correo != null)
            {
                var searchCorreo = context.Usuarios.Where(a => a.Correo == usuario.Correo).FirstOrDefault();
                if (searchCorreo != null)
                {
                    ModelState.AddModelError("CorreoDuplex", "Este correo ya está registrado");
                }
            }
            if (usuario.Nombre != null)
            {
                if (!validarLetras(usuario.Nombre))
                {
                    ModelState.AddModelError("NombreSoloLetras", "No se permiten números");
                }
            }
        }
        public bool validarnUMEROS(string numString)
        {
            char[] charArr = numString.ToCharArray();
            foreach (char cd in charArr)
            {
                if (!char.IsNumber(cd))
                    return false;
            }
            return true;
        }
        public bool validarLetras(string numString)
        {
            string parte = numString.Trim();
            int count = parte.Count(s => s == ' ');
            if (parte == "")
            {
                return false;
            }
            else if (count > 1)
            {
                return false;
            }
            char[] charArr = parte.ToCharArray();
            foreach (char cd in charArr)
            {
                if (!char.IsLetter(cd) && !char.IsSeparator(cd))
                    return false;
            }
            return true;
        }
    }
}