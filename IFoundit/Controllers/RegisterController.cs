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
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("","login");
            }
            return View();
        }
    }
}
