using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Klockia.Models
{
    public class ShopingCartViewModel
    {

        public Product Product { get; set; }
        [Display(Name = "Antal")]
        public int Amount { get; set; }
        [Display(Name = "Summa totalt")]
        public decimal TotalPrice { get; set; }


    }
}