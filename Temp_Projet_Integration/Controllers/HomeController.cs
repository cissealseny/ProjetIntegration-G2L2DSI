using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Temp_Projet_Integration.Models;

namespace Temp_Projet_Integration.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult chartjs()
        {
            return View();
        }
        public IActionResult basic_elements()
        {
            return View();
        }
        public IActionResult mdi()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult basic_table()
        {
            return View();
        }
        public IActionResult buttons()
        {
            return View();
        }
        public IActionResult dropdowns()
        {
            return View();
        }
        public IActionResult typography()
        {
            return View();
        }
        public IActionResult sidebar()
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
