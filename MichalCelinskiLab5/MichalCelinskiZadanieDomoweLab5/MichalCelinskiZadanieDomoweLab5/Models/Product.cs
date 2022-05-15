using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MichalCelinskiZadanieDomoweLab5.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa Produktu ")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }

        [Required]
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        [Display(Name = "Producent")]
        public Producer Producer { get; set; }

        [Required]
        [Display(Name = "Rok produkcji  ")]
        public int ProductionYear { get; set; }

        [ForeignKey("OrderId")]
        [Display(Name = "Producent")]
        public Order Order { get; set; }

    }
}
