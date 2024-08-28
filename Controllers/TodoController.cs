using Microsoft.AspNetCore.Mvc;
using twtodos.Models;
using twtodos.Contexts;

namespace twtodos.Controllers;

public class TodoController : Controller
{
    private readonly TWTodosContext _context;
    public TodoController(TWTodosContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todo = _context.Todos.First();
        return View(todo);
    }
}