using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MichalCelinskiZadanieDomoweLab5.Models;

namespace MichalCelinskiZadanieDomoweLab5.Controllers
{
    public class OrdersController : Controller
    {
        private readonly DataBaseContext _context;

        public OrdersController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult OrdersList()
        {
            return View(_context.Orders.ToList());
        }

    }
}
