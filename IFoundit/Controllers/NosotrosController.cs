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
    public class NosotrosController : Controller
    {
        private readonly MkContext context;

        public NosotrosController(MkContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {

            Usuario user = LoggedUser();
            if (user!=null)
            {
                return View();
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

    }
}
