using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class PopulateProductService :IPopulateProductService
    {
        public IList<Product> DefaultProducts { get; set; }

        public PopulateProductService(IProductRepository rp)
        {
            populateProds(rp);
        }
        public void populateProds(IProductRepository retrieveProducts)
        {
            DefaultProducts = retrieveProducts.CreateProducts();
        }

    }
}
