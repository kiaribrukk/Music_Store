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
        empresa.InicializarCatalogo();
        ViewBag.catalogo = empresa.catalogo;
        return View();
    }
    public IActionResult informaciónDisco(int id)
    {
        empresa.InicializarCatalogo();
        int i = -1;
        do
        {
            i++;
        } while (i < empresa.catalogo.Count && i != id);

        if (i < empresa.catalogo.Count) 
        ViewBag.disco = empresa.catalogo[i];
        return View();
    }
}
