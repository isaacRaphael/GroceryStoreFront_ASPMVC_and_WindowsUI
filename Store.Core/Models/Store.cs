using Store.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Core
{

    public class Store : IStore
    {
        
        public List<Product> Products { get; set; } 
        public double VAT { get; private set; }
        public User User { get; set; }
        public Store()
        {

        }
        public Store(IPopulateProductService populate)
        {
            Products = (List<Product>)populate.DefaultProducts;
            
        }
        public void UpdateProductPrice(string id, decimal newPrice)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    item.Price = newPrice;
            }
        }

        public void SetVAT(double newVAT)
        {
            VAT = newVAT;
        }

        public void AddToProduct(string id, int numberChange)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    item.Quantity += numberChange;
            }
        }

        public void RemoveFromProduct(string id, int numberChange)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    item.Quantity -= numberChange;
            }
        }

        public void DeleteProduct(string id)
        {
            int counter = 0;
            foreach (var item in Products)
            {

                if (item.Id == id)
                {
                    counter = Products.IndexOf(item);
                    break;
                }
            }
            Products.RemoveAt(counter);
        }

        public string CreateProduct(string nameOfProduct, int quantity = 0)
        {
            Product prod = new Product(nameOfProduct, quantity);
            Products.Add(prod);
            return prod.Id;
        }

        public Product GetProduct(string id)
        {
            foreach (var item in Products)
            {
                if (item.Id == id)
                    return item;
            }

            return null;
        }
    }
}