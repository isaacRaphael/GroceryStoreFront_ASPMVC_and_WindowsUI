using System.Collections.Generic;

namespace Store.Core
{
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
}