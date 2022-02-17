using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{
    public class Product
    {
        public Product(string productName, int quantity = 0)
        {
            Id = Guid.NewGuid().ToString().Substring(0,12);
            Name = productName;
            Quantity = quantity;
        }

        public Product(string productName, string id, decimal price, int quantity = 0)
        {
            Id = id;
            Name = productName;
            Quantity = quantity;
            Price = price;
        }
        public string Id { get; private set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
