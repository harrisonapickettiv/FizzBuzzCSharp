using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzBuzzMVC.Models;

namespace FizzBuzzMVC.Controllers
{
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

    [HttpGet]
    public IActionResult FBPage()
    {
      return View(new FizzBuzz());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult FBPage(FizzBuzz model)
    {
      return View(model.Update());
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
