using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZadanieDomowe4.Models
{
    public class MovieViewModell : Controller
    {
        /// <summary>
        /// konstruktor z parametrami 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="director"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="rate"></param>
        /// <param name="photo"></param>
        public MovieViewModell(string title, string director, int yearOfPublish, float rate, string photo)
        {
            Title = title;
            Director = director;
            YearOfPublish = yearOfPublish;
            Rate = rate;
            Photo = photo;

        }
        /// <summary>
        /// tytuł
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// rezyser
        /// </summary>
        public string Director { get; set; }
        /// <summary>
        /// data wydania 
        /// </summary>
        public int YearOfPublish { get; set; }
        /// <summary>
        /// ocena 
        /// </summary>
        public float Rate { get; set; }
        /// <summary>
        /// zdjecie 
        /// </summary>
        public string Photo { get; set; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
