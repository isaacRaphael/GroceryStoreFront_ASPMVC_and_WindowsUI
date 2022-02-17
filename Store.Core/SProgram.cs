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
                new Product("Ije garri", 900) { Price = 300m },
                new Product("Milo", 800) { Price = 1250m },
                new Product("Milk", 700) { Price = 1900m },
                new Product("Indomie", 600) { Price = 4100m },
                new Product("Sugar",800) { Price = 400m },
                new Product("Bread", 900) { Price = 700m }
            };

            return listOfProducts;
        }
    }
}
