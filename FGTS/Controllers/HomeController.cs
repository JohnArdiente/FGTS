using FGTS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FGTS.Controllers
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

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }

        public IActionResult Utilization()
        {
            return View();
        }

        public IActionResult Monitoring()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
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