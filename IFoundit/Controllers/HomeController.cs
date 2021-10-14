using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MkContext context;
        public HomeController(ILogger<HomeController> logger, MkContext context)
        {
            _logger = logger;
            this.context = context;
        }
      

        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user!=null)
            {
                ViewBag.Usuario = user;
                return RedirectToAction("", "dashboard");
            }
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private Usuario LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            if (claim!=null)
            {
                var user = context.Usuarios.Where(o => o.Correo == claim.Value).FirstOrDefault();
                return user;
            }
            return null;
        }
    }
}

