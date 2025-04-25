using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Music_Store.Models;

namespace Music_Store.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
