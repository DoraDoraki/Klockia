﻿using System.ComponentModel.DataAnnotations;

namespace Klockia.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}