using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MichalCelinksiLab6ZadanieDomowe.Models
{
    public class Product
    {
       
        public int Id { get; set; }

        public string ProductName { get; set; }

      
        public int CategoryId { get; set; }

        public int ProducerId { get; set; }

        public Producer Producer { get; set; }

        
        public int ProductionYear { get; set; }

        public Order Order { get; set; }
    }
}
