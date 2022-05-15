using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZadanieDomowe4.Models;

namespace ZadanieDomowe4.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// lista samochdow do wyswietlania
        /// </summary>
        List<MovieViewModell> allMovies;

        /// <summary>
        /// konstruktor z parametrem
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            allMovies = new List<MovieViewModell>();
            allMovies.Add( new MovieViewModell("The Shawshank Redemption", "Frank Darabont",1995, 10,"~/shawshank.jpg"));
            allMovies.Add(new MovieViewModell("God Father", "Christopher Nolan", 2010, 9, "~/godfather.jpg"));
            allMovies.Add(new MovieViewModell("Inception", "Francis Ford Coppola ", 1972, 8, "~/inception.jpg"));
            allMovies.Add(new MovieViewModell("Shrek", "Mike Mitchell", 2001, 7, "~/shrek.jpg"));

        }
        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllMovies()
        {
            return View(allMovies);
        }
        /// <summary>
        /// Lista wszystkich filmow z listy
        /// <returns></returns>
        public IActionResult GetListOfTitles()
        {

            List<string> allTitles = new List<string>();
            foreach (var movie in allMovies)
            {
                allTitles.Add(movie.Title);
            }
            return View(allTitles);
        }
        /// <summary>
        /// Pobieranie inforacji o filmie przez jego tytuł
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public IActionResult GetMovieByTitle(string title)
        {
            var movie = allMovies.Where(a => a.Title.ToLower() == title.ToLower()).FirstOrDefault();
            return View(movie); 
        }
        public IActionResult GetRandomMovie()
        {
            return View(allMovies);
        }
        public IActionResult ContactForm()
        {
            return View();
        }
        /// <summary>
        /// Wyświetlenie formularza do wypełnienia
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            string newTitle = userData.Title;
            ViewBag.UserName = fullName;
            ViewBag.Title = newTitle;

            
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
