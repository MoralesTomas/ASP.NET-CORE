using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index(){
            
            return View();
        }
    }
}