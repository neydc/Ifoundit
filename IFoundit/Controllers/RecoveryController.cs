using IFoundit.DB.Maps;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    public class RecoveryController : Controller
    {
        private readonly MkContext context;

        public RecoveryController(MkContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string correo)
        {
            if (string.IsNullOrEmpty(correo))
            {
                ModelState.AddModelError("Correo", "Ingrese correo de recuperación");
            }
            if (correo != null)
            {
                if (!Regex.Match(correo, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$").Success)
                {
                    ModelState.AddModelError("Correo2", "Correo inválido | nombre@dominio.com");
                    ViewBag.correoReturn = correo;
                }
                else {
                    var searchCorreo = context.Usuarios.Where(a => a.Correo == correo).FirstOrDefault();
                    if (searchCorreo == null)
                    {
                        ModelState.AddModelError("CorreoNoEncontrado", "Este correo ingresado no está registrado en nuestro sistema");
                        ViewBag.correoReturn = correo;
                    }
                }
            }
            if (ModelState.IsValid)
            {
                return SendEmail(correo);
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult SendEmail(string correo)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();

            message.From = new MailAddress("ifounditc@hotmail.com", "Ifoundit");
            var obtenerusuario = context.Usuarios.Where(a => a.Correo == correo).FirstOrDefault() ;
            message.To.Add(correo);
            message.Subject = "Ifoundit | " + "Recuperar Contraseña";
            message.IsBodyHtml = true;
            message.Body = "¡Hola! " + obtenerusuario.Nombre + "<br>" + "Recupere su contraseña en el siguiente enlace: " + "<hr>" + "<a href = 'http://ifoundit.site/Recovery/Recoverytoken'> http://ifoundit.site/?token=recovery" + obtenerusuario.Contrasenia + "</a>"+"<br> <br>" + "El enlace caducará en 4 horas";

            smtpClient.Port = 587;
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("ifounditc@hotmail.com", "g4pBSWnX");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(message);

            try
            {
                return View("Succes", "Recovery");
            }
            catch (Exception)
            {
                return View();
                throw;
            }

           
        }

        public IActionResult Succes()
        {
            return View();
        } public IActionResult Succes1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Recoverytoken()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Recoverytoken(string token)
        {
            return View();
        }
    }
}
