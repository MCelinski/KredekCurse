using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MichalCelinskiZadanieDomoweLab5.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa Kategorii")]
        public string CategoryName{ get; set; }

        

        public ICollection<Product> Products { get; set; }
    }
}

