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
    public class ContactoController : Controller
    {
        private readonly MkContext context;

        public ContactoController(MkContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            //var obtenerUsuarios = context.Objetos.ToList();
            //foreach (var item in obtenerUsuarios)
            //{
            //    Random aleatorio = new Random();
               // int num = aleatorio.Next(0, 20);
                //int num1 = aleatorio.Next(1, 6);
                //int num2 = aleatorio.Next(3, 9);
                //int num3 = aleatorio.Next(1, 8);
                //int num4 = aleatorio.Next(1, 6);
                //int num5 = aleatorio.Next(0, 9);
                //int num6 = aleatorio.Next(0, 9);
                //string texto = item.Nombre;
                //int posicion = texto.IndexOf(" ");
                //String substring = item.Nombre.ToString().Substring(0, posicion);
                //var nombre = substring;
                //switch (num)
                //{
                //    case 1:
                //        item.Correo = nombre + "_" + num2 + num3 + "@gmail.com";
                //        break;
                //    case 2:
                //        item.Correo = "N000" + num1 + num2 + num3 + num4 + num5 + "@upn.pe";
                //        break;
                //    case 3:
                //        item.Correo = "N00" + num6 + num1 + num2 + num3 + num4 + num5 + "@upn.pe";
                //        break;
                //    case 4:
                //        item.Correo = nombre.Substring(0, 1) + "_" + "19" + num6 + num3 + nombre + "@outlook.com";
                //        break;
                //    case 5:
                //        item.Correo = nombre + "." + "19" + num6 + num3 + "@gmail.com";
                //        break;
                //    case 6:
                //        item.Correo = nombre + "_" + num6 + num4 + "@gmail.com";
                //        break;

                //    default:
                //        break;
                //}
                //switch (num)
                //{
                //    case 1:
                //        item.Nombre = "Celular Xiaomi Negro";
                //        break;
                //    case 2:
                //        item.Nombre = "Celular Samsung Galaxy";
                //        break;
                //    case 3:
                //        item.Nombre = "Laptop Acer";
                //        break;
                //    case 4:
                //        item.Nombre = "Laptop Lenovo";
                //        break;
                //    case 5:
                //        item.Nombre = "Iphone 10";
                //        break;
                //    case 6:
                //        item.Nombre = "Iphone 12";
                //        break;
                //    case 7:
                //        item.Nombre = "Llaves de casa";
                //        break;
                //    case 8:
                //        item.Nombre = "Llaves de Carro";
                //        break;
                //    case 9:
                //        item.Nombre = "Billetera";
                //        break;
                //    case 10:
                //        item.Nombre = "Portafolio de documentos";
                //        break;
                //    case 11:
                //        item.Nombre = "Llaves";
                //        break;
                //    case 12:
                //        item.Nombre = "Celular";
                //        break;
                //    case 13:
                //        item.Nombre = "Documentos personales";
                //        break;
                //    case 14:
                //        item.Nombre = "Maletín";
                //        break;
                //    case 15:
                //        item.Nombre = "Celular Motorola";
                //        break;
                //    case 16:
                //        item.Nombre = "Mochila";
                //        break;
                //    case 17:
                //        item.Nombre = "maleta de viaje";
                //        break;
                //    case 18:
                //        item.Nombre = "Documentos en mototaxi";
                //        break;
                //    case 19:
                //        item.Nombre = "Maleta olvidada en auto";
                //        break;
                //    default:
                //        break;
                //}
                //context.SaveChanges();
           // }
            Usuario user = LoggedUser();
            if (user != null)
            {
                return View();
            }

            //var objetos = context.Objetos.ToList();
            //int i = 1;
            //foreach (var item in objetos)
            //{
            //    item.IdUsuario = i++;
            //    context.SaveChanges();
            //}
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
