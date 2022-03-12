using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class RemoveProdFromDbService : IRemoveProdFromDbService
    {
        private IProductRepository _productRepository;

        public RemoveProdFromDbService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool RemoveProd(string prodId)
        {
            bool result = _productRepository.RemoveFromProducts(prodId);
            return result;

        }
    }
}
