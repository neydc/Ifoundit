using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly MkContext context;

        public DashboardController(MkContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
                var misreportes = context.Objetos.Where(a => a.IdUsuario == user.Id).ToList();
                ViewBag.misreportes = misreportes.Count;
                return View(misreportes.OrderByDescending(a => a.FechaPublicacion));
            }
            else
            {
                return View("", "login");
            }
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

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
