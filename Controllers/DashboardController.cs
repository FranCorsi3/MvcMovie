using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard/Index
        public IActionResult Index()
        {
            ViewBag.WelcomeMessage = "Bienvenido al panel de control.";
            return View();
        }
    }
}
