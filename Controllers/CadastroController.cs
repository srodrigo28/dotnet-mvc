using Microsoft.AspNetCore.Mvc;

namespace twtodos.Controllers;

public class CadastroController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
