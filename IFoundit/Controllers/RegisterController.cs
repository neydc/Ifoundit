using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    public class RegisterController : Controller
    {
        private readonly MkContext _context;
       
        public RegisterController(MkContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }  

        [HttpPost]
        public IActionResult SignUp(Usuario usuario)
        {
            validarDatos(usuario);
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("", "login");
            }
            return View(usuario);

        }

        private void validarDatos(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nombre))
            {
                ModelState.AddModelError("Nombre","Ingrese su nombre");
            }
           
            if (string.IsNullOrEmpty(usuario.Contrasenia))
            {
                ModelState.AddModelError("Contrasenia","Ingrese su contraseña");
            } 

           
            if (!validarLetras(usuario.Nombre))
            {
                ModelState.AddModelError("NombreSoloLetras", "No se permiten números");
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
        public bool validarLetras(string numString){
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
