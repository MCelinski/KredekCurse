using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MichalCelinskiZadanieDomoweLab5.Models;

namespace MichalCelinskiZadanieDomoweLab5.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly DataBaseContext _context;

        public CategoriesController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult CategoriesList()
        {
            return View(_context.Categories.ToList());
        }

    }
}
