using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_stevenf4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_stevenf4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View("Podcast");
        }

        [HttpGet]
        public IActionResult MovieEntry()
        {
            return View("M");
        }

        [HttpPost]
        public IActionResult MovieEntry(ApplicationResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();
            return View("Confirmation", ar);
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
