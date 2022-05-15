using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MichalCelinskiZadanieDomoweLab5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MichalCelinskiZadanieDomoweLab5.Controllers
{
    public class ProducersController:Controller
    {
        private readonly DataBaseContext _context;

        public ProducersController(DataBaseContext context)
        {
            this._context = context;
        }

        public IActionResult ProducersList()
        {
            return View(_context.Producers.ToList());
        }

    }
}
