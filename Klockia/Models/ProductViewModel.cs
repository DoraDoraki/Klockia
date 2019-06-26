using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Klockia.Models
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bild")]
        public string ImageUrl { get; set; }
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Märke")]
        public string Brand { get; set; }

        [Display(Name = "Pris")]
        public int Price { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Display(Name = "Färg")]
        public string Color { get; set; }

        public int ProductTypeId { get; set; }
        public List<ProductType> ProductTypes { get; set; }
    }
}