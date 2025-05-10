using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MensajeBienvenida = "¡Bienvenido al panel de usuario!";
            return View();
        }
    }
}