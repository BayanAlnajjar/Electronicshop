using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Classes
{
    public class ProData
    { 
        public static List<Product> GetProducts()
        {
            List<Product> p = new List<Product>();
            p.Add(new Product { Id=1,    Name= "Asus",       Category="laptop",        Price=240,    StockQuantity = 15});
            p.Add(new Product { Id = 2,  Name = "HP",        Category = "laptop",      Price = 1400, StockQuantity = 15 });
            p.Add(new Product { Id = 3,  Name = "Lenovo",    Category = "laptop",      Price = 120,  StockQuantity = 15 });
            p.Add(new Product { Id = 4,  Name = "Mac",       Category = "laptop",      Price = 50,   StockQuantity = 20 });
            p.Add(new Product { Id = 5,  Name = "Samsung",   Category = "mobile",      Price = 300,  StockQuantity = 30 });
            p.Add(new Product { Id = 6,  Name = "Redmi",     Category = "mobile",      Price = 300,  StockQuantity = 45 });
            p.Add(new Product { Id = 7,  Name = "Poco",      Category = "mobile",      Price = 700,  StockQuantity = 12 });
            p.Add(new Product { Id = 8,  Name = "Honor",     Category = "mobile",      Price = 1240, StockQuantity = 9 });
            p.Add(new Product { Id = 9,  Name = "iphone",    Category = "mobile",      Price = 200,  StockQuantity = 65 });
            p.Add(new Product { Id = 10, Name = "headphones",Category = "accesseries", Price = 100,  StockQuantity = 20 });
            p.Add(new Product { Id = 11, Name = "webcam",    Category = "accesseries", Price = 150,  StockQuantity = 23 });
            p.Add(new Product { Id = 12, Name = "mouse",     Category = "accesseries", Price = 50 ,  StockQuantity = 18 });
            p.Add(new Product { Id = 13, Name = "keyboard",  Category = "accesseries", Price = 400,  StockQuantity = 12 });
            p.Add(new Product { Id = 14, Name = "laoptopBag",Category = "accesseries", Price = 400,  StockQuantity = 32 });
            p.Add(new Product { Id = 15, Name = "CDs",       Category = "accesseries", Price = 400,  StockQuantity = 22 });

            return p;
        }
    }
}
