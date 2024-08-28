using Microsoft.AspNetCore.Mvc;

namespace twtodos.Controllers;

public class CadastroController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Cadastro novo User";
        return View();
    }
}
