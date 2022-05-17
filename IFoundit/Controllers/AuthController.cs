using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
            return View();
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
                ViewBag.usuario = correo;
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
            ViewBag.usuario = correo;
            ViewBag.password = password;
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
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return RedirectToAction("", "login");
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
                ModelState.AddModelError("Nombre", "Ingrese su nombre");
            }
           
            if (usuario.Sexo==0)
            {
                ModelState.AddModelError("Sexo", "Ingrese su género");
            }
            if (string.IsNullOrEmpty(usuario.Celular))
            {
                ModelState.AddModelError("Celular", "Ingrese su número celular");
            }
            if (string.IsNullOrEmpty(usuario.Correo))
            {
                ModelState.AddModelError("Correo", "Ingrese su correo electrónico");
            }
            if (string.IsNullOrEmpty(usuario.Contrasenia))
            {
                ModelState.AddModelError("Contrasenia", "Ingrese su contraseña");
            }

            if (usuario.Correo != null)
            {
                var searchCorreo = context.Usuarios.Where(a => a.Correo == usuario.Correo).FirstOrDefault();
                if (searchCorreo!=null)
                {
                    ModelState.AddModelError("CorreoDuplex", "Este correo ya está registrado");
                }
            }
            if (usuario.Nombre!=null)
            {
                if (!validarLetras(usuario.Nombre))
                {
                    ModelState.AddModelError("NombreSoloLetras", "No se permiten números");
                }
            }
            if (usuario.Apellidos!=null)
            {
                if (!validarLetras(usuario.Apellidos))
                {
                    ModelState.AddModelError("ApellidoSoloLetras", "No se permiten números");
                }
            }
            if (usuario.Apellidos!=null)
            {
                if (!validarLetras(usuario.Apellidos))
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
