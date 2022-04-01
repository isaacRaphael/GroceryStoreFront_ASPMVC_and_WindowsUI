using Store.Core.Models;
using System.Collections.Generic;

namespace Store.Core.Services
{
    public interface ICartService
    {
        void ClearCart();
        List<CartDTO> GetCart();
        void Add(CartDTO cartDTO);
    }
}