using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{

    public class UpdateDbOnCkeckOutService : IUpdateDbOnCkeckOutService
    {
        private readonly IProductRepository _productRepository;

        public UpdateDbOnCkeckOutService(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }

        public bool UpdateOnChechOut(string prodid, int qty)
        {
            return _productRepository.UpdateDbOnCheckOut(prodid, qty);
        }
    }
}
