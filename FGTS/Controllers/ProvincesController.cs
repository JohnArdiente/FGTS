using Microsoft.AspNetCore.Mvc;

namespace FGTS.Controllers
{
    public class ProvincesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
