using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Classes
{
    public class Linq
    {
        public static void LPro(List<Product> products)
        {
            Console.WriteLine("1.Available Produsts");
            var avPro = products.Where(p => p.StockQuantity > 0).OrderByDescending(p => p.Price);
            foreach (var product in avPro) { Console.WriteLine(product); }

            Console.WriteLine("products from one Category");
            var CatPro = products.Where(p => p.Category == "A1");
            foreach (var product in CatPro) { Console.WriteLine(product); }

            Console.WriteLine("Products name");
            var ProName = products.Select(p => p.Name);
            foreach (var product in CatPro) { Console.WriteLine(product.Name); }

            Console.WriteLine("Avarege & Max");
            decimal avg = products.Average(p => p.Price);
            decimal max = products.Max(p => p.Price);
            Console.WriteLine($"Avarege Price: {avg}");
            Console.WriteLine($"max price:{max}");


            Console.WriteLine("all products for one Category");
            var G = products.GroupBy(p => p.Category);
            foreach (var g in G) { Console.WriteLine($"products{G}"); }

            Console.WriteLine("Are there books greater than 1500$ ??");
            bool p = products.Any(b => b.Price >= 1500);
             Console.WriteLine(p);

            Console.WriteLine("Skip and Take");
            var s = products.OrderByDescending(p => p.Price).Skip(1).Skip(2).Take(3);
            foreach (var ss in s)
            {
                Console.WriteLine(ss);

            }
        }
    }
}
