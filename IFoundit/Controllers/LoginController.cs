using IFoundit.DB.Maps;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    public class LoginController : Controller
    {
        private readonly MkContext context;

        public LoginController(MkContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string correo, string password)
        {
            if (correo!=null && password!=null)
            {
                var userv = context.Usuarios.Where(o => o.Correo == correo && o.Contrasenia == password).FirstOrDefault();
                if (userv != null)
                {
                    var claims = new List<Claim> {
                             new Claim(ClaimTypes.Name, email)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    HttpContext.SignInAsync(claimsPrincipal);
                    //return Json(new { dashboard = 1 });
                    //return RedirectToAction("Index", "dashboard");
                    return Json(new { dashboard = 1 });


                }
            }
            return View();
        }
    }
}
