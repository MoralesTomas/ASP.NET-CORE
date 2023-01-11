using ASP.NET_CORE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index(){
            
            var escuela = new Escuela();
            escuela.Nombre = "U.A";
            escuela.AñoFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid().ToString();
            
            //mandamos la escuela como modelo hacia la vista.
            return View( escuela );
        }
    }
}