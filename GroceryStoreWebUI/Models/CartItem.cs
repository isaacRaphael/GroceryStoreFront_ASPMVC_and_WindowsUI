using Store.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreWebUI.Models
{
    public class CartItem
    {
        private  decimal total;
        public string Name { get; set; }
        public string Id { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get {
                total = Price * (decimal)Quantity;
                return total;
            } set
            {
                total = value;
            }
        }
        public List<Product> Products { get; set; }
        public User User { get; set; }


    }
}
