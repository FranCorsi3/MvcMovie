using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensaje = "¡Bienvenido al panel de control!";
            return View();
        }
    }
}