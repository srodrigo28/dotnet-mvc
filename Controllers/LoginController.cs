using Microsoft.AspNetCore.Mvc;

namespace twtodos.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
