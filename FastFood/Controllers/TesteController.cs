using Microsoft.AspNetCore.Mvc;

namespace FastFood.Controllers;

public class TesteController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}