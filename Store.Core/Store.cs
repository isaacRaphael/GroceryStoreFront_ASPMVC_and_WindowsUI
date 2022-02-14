using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{
    public interface IStore : IStoreManager, IStoreStaff
    {

    }
    public interface IStoreManager
    {
        List<Product> Products { get; set; }
        double VAT { get; }
        void AddToProduct(string id, int numberChange);
        string CreateProduct(string nameOfProduct, int quantity = 0);
        void DeleteProduct(string Id);
        void SetVAT(double newVAT);
        void UpdateProductPrice(string id, decimal newPrice);
    }

    public interface IStoreStaff
    {
        void RemoveFromProduct(string id, int numberChange);
        Product GetProduct(string id);
    }

    public class Store : IStore
    {
        public List<Product> Products { get; set; } = SProgram.CreateProducts();
        public double VAT { get; private set; }

        public Store()
        {
           
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