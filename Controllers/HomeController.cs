using Assignment3Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3Movies.Controllers
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

        public IActionResult seeTheMovies()
        {
            return View(tempStorage.Applications);
        }

        public IActionResult bacon()
        {
            return View();
        }

        public IActionResult confirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult addMovie()
        {
            return View();
        }

        [HttpPost]

        public IActionResult addMovie(movie appResponse)
        {
            if(ModelState.IsValid)
            {
                if(appResponse.Title.ToUpper() != "INDEPENDENCE DAY")
                {
                    tempStorage.AddApplication(appResponse);
                    return View("confirmation", appResponse);
                }
                else
                {
                    return View("confirmation", appResponse);
                }
            }
            else
            {
                return View();
            }
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
