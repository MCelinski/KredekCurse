using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MichalCelinskiZadanieDomoweLab5.Models;
using Microsoft.EntityFrameworkCore;

namespace MichalCelinskiZadanieDomoweLab5.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataBaseContext _context;

        public ProductsController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult ProductsList()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction(nameof(ProductsList));
        }
        public IActionResult Edit(int id)
        {
            var product = _context.Products.FirstOrDefault(m => m.Id.Equals(id));

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(ProductsList));
            }

            return View(product);
        }
        public IActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(m => m.Id.Equals(id));

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction(nameof(ProductsList));
        }
    }
}