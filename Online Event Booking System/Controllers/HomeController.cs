using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Event_Booking_System.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Event_Booking_System.Controllers
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
        public IActionResult mumbai()  
        {
            return View();
        }
        public IActionResult delhi()
        {
            return View();
        }
        public IActionResult kolkata()
        {
            return View();
        }
        public IActionResult music()
        {
            return View();
        }
        public IActionResult comedy()
        {
            return View();
        }
        public IActionResult magic()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Registration()
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
