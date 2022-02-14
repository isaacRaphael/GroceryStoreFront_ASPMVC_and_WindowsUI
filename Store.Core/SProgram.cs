using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{
    public class SProgram
    {
        public static List<Product> CreateProducts()
        {
            var listOfProducts = new List<Product>()
            {
                new Product("Ije garri") { Price = 300m },
                new Product("Milo") { Price = 1250m },
                new Product("Milk") { Price = 1900m },
                new Product("Indomie") { Price = 4100m },
                new Product("Sugar") { Price = 400m },
                new Product("Bread") { Price = 700m }
            };

            return listOfProducts;
        }
    }
}
