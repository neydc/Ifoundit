﻿using IFoundit.DB.Maps;
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
    public class LoginController : Controller
    {
        private readonly MkContext context;

        public LoginController(MkContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            Usuario user = LoggedUser();
            if (user!=null)
            {
                return RedirectToAction("","Dashboard");
            }
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
                             new Claim(ClaimTypes.Name, correo)
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    HttpContext.SignInAsync(claimsPrincipal);
                    //return Json(new { dashboard = 1 });
                    return RedirectToAction("Index", "dashboard");
                  
                }
                else
                {
                    return View("Index");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
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