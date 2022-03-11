using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core
{
    class CheckOut
    {

        private readonly IStore _store;

        public CheckOut(IStore store)
        {
            _store = store;
        }
        public decimal CalculateVAT(decimal totalPrice)
        {
            return totalPrice + (totalPrice * (decimal)_store.VAT / 100);
        }

        public decimal CalculateDiscount(string id, double discountRate)
        {
            var discount = 0m;
            foreach (var item in _store.Products)
            {
                if (item.Id == id)
                { discount = item.Price - (item.Price * (decimal)discountRate); }
            }
            return discount;
        }
    }

    //public class SeasonCheckOut : CheckOut
    //{
    //    private readonly string _message;

    //    public SeasonCheckOut(Store store, string message) : base(store)
    //    {
    //        _message = message;
    //    }

    //    public void Greet()
    //    {
    //        System.Console.WriteLine(_message);
    //    }
    //}
}
