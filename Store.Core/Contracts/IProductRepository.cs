using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        bool AddToProducts(string id, string prodName, decimal prodPrice, int qty);
        bool RemoveFromProducts(string id);
        bool UpdateDbOnCheckOut(string id, int qty);

        
    }
}