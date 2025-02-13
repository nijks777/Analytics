using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NEWTECHM.Models;

namespace NEWTECHM.Controllers
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
        public IActionResult ERPSustainablePractices()
        {
            return View();
        }

        public IActionResult CloudDatabaseInnovation()
        {
            return View();
        }

        public IActionResult DatabaseComparison()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
            public IActionResult Resources()
            {
                return View();
            }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Career()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult BusinessAutomation()
        {
            return View();
        }

        public IActionResult DataAI()
        {
            return View();
        }
        public IActionResult CloudImplementation()
        {
            return View();
        }

        public IActionResult DataAnalytics()
        {
            return View();
        }
        public IActionResult MaintenanceSupport()
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
