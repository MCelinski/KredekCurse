using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MichalCelinskiZadanieDomoweLab5.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Id Produktu")]
        public int ProductId { get; set; }
       
        [Required]
        [Display(Name = "Ilość")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Wartość")]
        public int Value { get; set; }



    }
}
