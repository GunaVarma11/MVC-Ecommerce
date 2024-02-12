using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce_mvc.Models
{
    public class Cart
    {
        Product p=new Product();
        public Product Details(int id)
        {
            Product laptop = new Product();
            switch (id)
            {
                case 1:
                    laptop = new Product()
                    {
                        ProductId = 101,
                        Brand = "Apple",
                        Model = "M1",
                        Price = 87000,
                        Storage = 256 
                    };
                    break;
                case 2:
                    laptop = new Product()
                    {
                        ProductId = 105,
                        Brand = "Surface",
                        Model = " corei7",
                        Price = 182000,
                        Storage = 256
                    };
                    break;
                case 3:
                    laptop = new Product()
                    {
                        ProductId = 102,
                        Brand = "Asus",
                        Model = "i7",
                        Price = 85000,
                        Storage = 512
                    };
                    break;
                case 4:
                    laptop = new Product()
                    {
                        ProductId = 103,
                        Brand = "Apple",
                        Model = "M2",
                        Price = 153300,
                        Storage = 512
                    };
                    break;
            }
            return laptop;
        }
    }
}