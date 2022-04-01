using MVC_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Core;
using Store.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoginService _loginService;
        private readonly IStore _store;
        private readonly CartItem _cartItem;

        public List<CartItem> Items { get; set; } = new();




        public HomeController(ILogger<HomeController> logger, ILoginService loginService, IStore store)
        {
            _logger = logger;
            _loginService = loginService;
            _store = store;
            _cartItem = new CartItem() { Products = _store.Products };
        }


        //Get Index
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CartItems()
        {
            return View(Items);
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
            if (ModelState.IsValid)
                Items.Add(cartItem);

            return RedirectToAction("StoreFront", _cartItem);
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
