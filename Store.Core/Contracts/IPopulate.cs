using System.Collections.Generic;

namespace Store.Core.Services
{
    public interface IPopulate
    {
        IList<Product> DefaultProducts { get; set; }

        void populateProds(IProductRepository retrieveProducts);
    }
}