using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IFoundit.Controllers
{
    public class ReporteController : Controller
    {
        private readonly MkContext context;
        [Obsolete]
        private IHostingEnvironment ihostingEnvironment;

        [Obsolete]
        public ReporteController(MkContext context, IHostingEnvironment _hostingEnvironment)
        {
            this.context = context;
            ihostingEnvironment = _hostingEnvironment;
        }
        public ActionResult Index()
        {
            IEnumerable<Objeto> listObject = context.Objetos;
         
            var usuarios = context.Usuarios.ToList();
            ViewBag.users = usuarios;
            return View(listObject.ToList());
        }

        public JsonResult getReportes() {
            var objectos = context.Objetos.ToList();
            return Json(objectos);
        }

        [Authorize]
        [HttpGet]
        public ActionResult MisReportes()
        {
            Usuario user = LoggedUser();
            if (user!=null)
            {
                ViewBag.Usuario = user;
                var misreportes = context.Objetos.Where(a=>a.IdUsuario==user.Id).ToList();
                return View(misreportes.OrderByDescending(a => a.FechaPublicacion));
            }
            else
            {
            return View("","login");
            }
        }

        // GET: ReporteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReporteController/Create
        [HttpGet]
        public ActionResult Create()
        {
            var categorias = context.Categorias.ToList();
            ViewBag.categorias = categorias;
            return View();
        }

        // POST: ReporteController/Create
        [HttpPost]
        [Obsolete]
        public ActionResult Create(Objeto objeto, IFormFile photos)
        {
           
                if (ModelState.IsValid)
                {
                    var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "PostImg", photos.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photos.CopyToAsync(stream);
                    objeto.FechaPublicacion = DateTime.Now;
                    objeto.Imagen = photos.FileName;

                    context.Add(objeto);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
        }

        // GET: ReporteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReporteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReporteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
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
    }
}
