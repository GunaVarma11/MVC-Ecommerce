using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_commerce_mvc.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public int Storage { get; set; }

    }
}