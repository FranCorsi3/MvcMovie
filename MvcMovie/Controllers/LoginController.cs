using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string username, string password)
    {
        // Lógica de autenticación muy simple (solo a modo de ejemplo)
        if (username == "admin" && password == "1234")
        {
            // Guardamos la sesión
            HttpContext.Session.SetString("Usuario", username);

            // Redirigimos al dashboard
            return RedirectToAction("Index", "Dashboard");

        }

        ViewBag.Error = "Usuario o contraseña incorrectos";
        return View();
    }
}