using Store.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Contracts
{
    public interface ICartRepository
    {
        List<CartDTO> GetCartItems();
        void ClearCartItems();
        void AddItem(CartDTO cartDTO);

        CartDTO GetItem(string id);
    }
}
