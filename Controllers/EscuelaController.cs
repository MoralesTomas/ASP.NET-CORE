using ASP.NET_CORE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index(){
            
            var escuela = new Escuela();
            escuela.Nombre = "U.A";
            escuela.AñoDeCreación = 2005;
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Ciudad = "Guatemala";
            escuela.Pais = "Guatemala ";
            escuela.Dirección = "Avd Siempre viva";
            escuela.TipoEscuela = TiposEscuela.Secundaria;
            ViewBag.CosaDinamica = "La Monja";
            
            //mandamos la escuela como modelo hacia la vista.
            return View( escuela );
        }
    }
}