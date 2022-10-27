using Ejemplo1Asp.Models;
using Ejemplo1Asp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class OperasBasController : Controller
    {
        //  GET: OperasBas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasService();
            var model = PeliculasService.ObtenerPelicula();
            return View(model);
        }
        public ActionResult Sumar()
        {
            var tem = new Calculos();
            return View(tem);
        }
        [HttpPost]
            public ActionResult Sumar(Calculos calculos, string r1)
        {

            var tem = new Calculos();
            tem = calculos;
            if (r1.Equals("Sumar"))
            {
                tem.Suma();
            }
            if (r1.Equals("Restar"))
            {
                tem.Resta();
            }


            ViewBag.res = tem.Resultado;
            return View();
        }
        public RedirectToRouteResult Temporal()
        {

            return RedirectToAction("About", "Home");
            // var alumno1 = new Alumno() { Nombre = "Iza", Edad = 15 };
            //var alumno2 = new Alumno() { Nombre = "Sofia", Edad = 16 };
            //return Json(new List<Alumno>() { alumno1, alumno2}, JsonRequestBehavior.AllowGet);
            //  return Content("Hola Mundo");

        }

        public ActionResult vista()
        {
            ViewBag.Nombre = "Sofia";
            ViewData["Nom"] = "Iza";
            return View();
        }
    }
}