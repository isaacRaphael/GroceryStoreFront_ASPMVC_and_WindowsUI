using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core
{
    public interface IProductRepository
    {
        List<Product> CreateProducts();
        bool AddToProducts(string id, string prodName, decimal prodPrice, int qty);
    }
}