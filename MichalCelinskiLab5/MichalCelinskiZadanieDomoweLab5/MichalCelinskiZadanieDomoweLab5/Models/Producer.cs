using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MichalCelinskiZadanieDomoweLab5.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Producent")]
        public string ProducerName { get; set; }

        [Required]
        [Display(Name = "Kraj")]
        public string ProducerCountry { get; set; }

        [Required]
        [Display(Name = "Miasto")]
        public string ProducerCity { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
