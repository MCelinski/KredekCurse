using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZadanieDomowe4.Models
{
    public class ContactFormViewModel
    {/// <summary>
    /// imie
    /// </summary>
        public string FirstName { get; set; }
    /// <summary>
    /// nazwisko
    /// </summary>
        public string LastName { get; set; }
    /// <summary>
    /// tytuł
    /// </summary>
        public string Title { get; set; }
    }
}


