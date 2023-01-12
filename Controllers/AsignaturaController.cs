using System;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_CORE.Models;

namespace ASP.NET_CORE.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura{
                UniqueId = Guid.NewGuid().ToString(),
                Nombre="Programación"
            };

            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }
    }
}