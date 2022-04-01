using Store.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreWebUI.Models
{
    public class CartItem
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total
        {
            get
            {
                return Price * (decimal)Quantity;
            }
            set
            {
                Total = value;
            }
        }
        public List<Product> Products { get; set; }

    }
}
