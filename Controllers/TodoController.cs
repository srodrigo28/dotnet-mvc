using Microsoft.AspNetCore.Mvc;

namespace twtodos.Controllers;

public class TodoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}