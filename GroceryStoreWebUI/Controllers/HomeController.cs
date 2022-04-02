using GroceryStoreWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Core;
using Store.Core.Models;
using Store.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoginService _loginService;
        private readonly ICartService _cartService;
        private readonly IAddProdToDbService _addProdToDbService;
        private readonly IRemoveProdFromDbService _removeProdFromDbService;
        private readonly IStore _store;
        private readonly CartItem _cartItem;


        public HomeController(ILogger<HomeController> logger,
            ILoginService loginService,
            ICartService cartService, 
            IStore store,
            IRemoveProdFromDbService removeProdFromDbService,
            IAddProdToDbService addProdToDbService)
        {
            _logger = logger;
            _loginService = loginService;
            _store = store;
            _cartService = cartService;
            _cartItem = new CartItem() { Products = _store.Products, User =_store.User };
            _addProdToDbService = addProdToDbService;
            _removeProdFromDbService = removeProdFromDbService;
           
        }


        //Get Index
        public IActionResult Index()
        {
            return View();
        }
        
        
        //CreateProd Get
        public IActionResult CreateProd()
        {
            return View();
        }

        //CreateProd Post
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateProd(CartItem item)
        {
            var prod = new Product(item.Name)
            {
                Quantity = item.Quantity,
                Price = item.Price
            };
            _addProdToDbService.AddProdToDb(prod.Id, prod.Name, prod.Price, prod.Quantity);
            return RedirectToAction("StoreFront");
        }

        //DeleteProd Get
        public IActionResult DeleteProd()
        {
            return View();
        }

        //DeleteProd Post
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteProd(CartItem cartItem)
        {
            _removeProdFromDbService.RemoveProd(cartItem.Id);
            return RedirectToAction("StoreFront");
        }

        public IActionResult Print()
        {
            var items = _cartService.GetCart();
            var printOut = "";

            foreach(var item in items)
            {
                printOut += $"Product: {item.Name}\n Quantity: {item.Quantity}\n Unit Price: {item.Price}\n Product Total: {item.Price * item.Quantity}\n";
            }
            printOut += $"Grand Total: {items.Sum(x => x.Price * x.Quantity)}";
            
            var fileUniqueName = Guid.NewGuid().ToString().Substring(0, 5);
        
            FileStream f = new FileStream($@"E:\Project Files\C# sandbox\VS_2017\GroceryStoreFront\GroceryStoreFront\GroceryStoreWebUI\Receipts\{fileUniqueName}receipt.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine(printOut);
            s.Close();
            f.Close();

            _cartService.ClearCart();
            return View(new CartItem() { Name = fileUniqueName });
        }

        public IActionResult CartItems()
        {
            var CartList = new List<CartItem>();
            var Items = _cartService.GetCart();
            foreach(var item in Items)
            {
                CartList.Add(new CartItem()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Price = item.Price,
                    Quantity = item.Quantity
                });
            }
            return View(CartList);
        }



        //Post Login
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var checker = _loginService.ValidateLogIn(model.UserName, model.PassWord);
                if (checker)
                {
                    _store.User = new User(model.UserName);

                    return RedirectToAction("StoreFront", _cartItem);
                }
            }
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CartAdd(CartItem cartItem)
        {
            var pass = new CartDTO()
            {
                Id = cartItem.Id,
                Name = cartItem.Name,
                Price = cartItem.Price,
                Quantity = cartItem.Quantity
            };

            if (ModelState.IsValid)
                _cartService.Add(pass);

            return RedirectToAction("StoreFront", _cartItem);
        }

        public IActionResult Back()
        {
            _cartService.ClearCart();
            return RedirectToAction("StoreFront");
        }
        public IActionResult StoreFront()
        {
            return View(_cartItem);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
