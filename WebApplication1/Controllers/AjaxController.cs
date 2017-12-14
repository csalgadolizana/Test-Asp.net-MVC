using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Vista1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(PersonaModel p)
        {
            string nombre = p.Name;
            string fecha = DateTime.Now.ToString();
            p.Fecha = fecha;

            return View(p);
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            Console.WriteLine("Lllegooo al metodo");
            PersonaModel p = new PersonaModel
            {
                Name = name,
                Fecha = DateTime.Now.ToString()
            };
            return Json(p);
        }
    }
}
