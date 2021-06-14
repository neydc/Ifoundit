using IFoundit.DB.Maps;
using IFoundit.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
      
        public async Task<IActionResult> Index(string sortOrder, string query, string currentFilter, string perdidos, string encontrados, int? page)
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
            }

            var num = context.Objetos.ToList();
            var contents = context.Objetos.AsQueryable();
            var usuarios = context.Usuarios.ToList();
            ViewBag.users = usuarios;

            //Pagination
            ViewData["TitleSort"] = string.IsNullOrEmpty(sortOrder) ? "Nom_Desc" : "";
            ViewData["Objperdidos"] = string.IsNullOrEmpty(perdidos) ? "perdidos" : "";
            ViewData["ObjEncontrados"] = string.IsNullOrEmpty(perdidos) ? "encontrados" : "";
            if (query != null)
                {
                    page = 1;
                }
                else
                {
                    query = currentFilter;
            }

                ViewData["currentFilter"] = query;
                ViewData["perdidos"] = query;
                ViewData["encontrados"] = query;

                if (!string.IsNullOrEmpty(query))
                {
                    contents = contents.Where(a=>a.Nombre.Contains(query));
                    ViewBag.count = contents.Count();
                }

            switch (sortOrder)
            {
                case "Nom_Desc":
                    contents = contents.OrderBy(s => s.Nombre);
                    break;
                case "perdidos":
                    contents = contents.Where(a=>a.Estado== "Perdido");
                    break;
                case "encontrados":
                    contents = contents.Where(a => a.Estado == "Encontrado");
                    break;
                default:
                    contents = contents.OrderByDescending(s => s.FechaPublicacion);
                    break;
            }
            int pageSize = 6;
            return View(await PaginatedList<Objeto>.CreateAsync(contents.AsNoTracking(), page ?? 1, pageSize));
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
        [HttpGet]
        public ActionResult Details(int id)
        {
            var detailObject = context.Objetos.Where(a=>a.Id==id).FirstOrDefault();
            if (detailObject == null)
            {
                return View("Error");
            }
            var usuarios = context.Usuarios.ToList();
            ViewBag.users = usuarios;
            return View(detailObject);
        }

        // GET: ReporteController/Create
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            Usuario user = LoggedUser();
            if (user != null)
            {
                ViewBag.Usuario = user;
            }
            var categorias = context.Categorias.ToList();
            ViewBag.categorias = categorias;
            return View();
        }

        // POST: ReporteController/Create
        [HttpPost]
        [Obsolete]
        public ActionResult Create(Objeto objeto, IFormFile photos)
        {
            validar(objeto);
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

        private void validar(Objeto objeto)
        {
            if (objeto.Nombre==null)
            {
                ModelState.AddModelError("Nombre","El campo nombre es requerido");
            } 
            if (objeto.Recompensa==null)
            {
                ModelState.AddModelError("Nombre","Ingrese una recompensa");
            }
            if (objeto.Categoria==null)
            {
                ModelState.AddModelError("Nombre","Campo nombre requerido");
            }
            if (objeto.Descripcion==null)
            {
                ModelState.AddModelError("Nombre","Campo nombre requerido");
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
