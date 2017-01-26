using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiIdiomaEleccion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.IdiomasVB = ObtenerIdiomasDisponibles();
            return View();
        }

        public RedirectToRouteResult SeleccionarIdioma(string Cultura)
        {
            var cookie = new HttpCookie("Idioma", Cultura);
            cookie.Expires = DateTime.Today.AddYears(1);
            Response.SetCookie(cookie);

            return RedirectToAction("Index");
        }

        public List<SelectListItem> ObtenerIdiomasDisponibles()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Español", Value = "es-DO" },
                new SelectListItem() {Text ="English", Value="en-US" }
            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}