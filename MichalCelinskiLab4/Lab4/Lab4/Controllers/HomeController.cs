using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        List<CarViewModel> allCars;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            allCars = new List<CarViewModel>();
            allCars.Add(new CarViewModel("Focus", "Ford", 72000, "~/focus.png"));
            allCars.Add(new CarViewModel("Golf", "Volswagen", 45500, "~/golf.png"));
            allCars.Add(new CarViewModel("Civic", "Honda", 72000, "~/civic.png"));
            allCars.Add(new CarViewModel("Megan", "Renault", 12750, "~/megan.png"));

        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult InterestingLinks()
        {
            return View();
        }

        public IActionResult GetAllCars()
        {
            return View(allCars);
        }

        public IActionResult GetListOfModels()
        {
         
            List<string> allModels = new List<string>();
            foreach(var car in allCars)
            {
                allModels.Add(car.Model);
            }
            return View(allModels);
        }

        public IActionResult GetCarByModel(string model)
        {
            var car = allCars.Where(a => a.Model.ToLower() == model.ToLower()).FirstOrDefault();
            return View(car);
        }

        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactFormGreetings");
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
