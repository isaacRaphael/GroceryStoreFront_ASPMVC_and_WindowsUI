using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{

    public class AddProdToDbService : IAddProdToDbService
    {
        private IProductRepository _productRepository;
        public AddProdToDbService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool AddProdToDb(string id, string pn, decimal prc, int qt)
        {
            bool result = _productRepository.AddToProducts(id, pn, prc, qt);
            return result;
        }

    }
}
