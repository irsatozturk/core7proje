using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using core7proje.Models;

namespace core7proje.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
