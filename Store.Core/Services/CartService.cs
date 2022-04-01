using Store.Core.Contracts;
using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepo;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepo = cartRepository;
        }
        public List<CartDTO> GetCart()
        {
            var items = _cartRepo.GetCartItems();
            return items;
        }

        public void ClearCart()
        {
            _cartRepo.ClearCartItems();
        }

        public void Add(CartDTO cartDTO)
        {
            _cartRepo.AddItem(cartDTO);
        }
    }
}
