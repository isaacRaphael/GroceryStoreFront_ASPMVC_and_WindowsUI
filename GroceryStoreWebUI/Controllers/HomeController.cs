using GroceryStoreWebUI.Models;
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

        public HomeController(ILogger<HomeController> logger, ILoginService loginService, IStore store )
        {
            _logger = logger;
            _loginService = loginService;
            _store = store;
        }


        //Get Index
        public IActionResult Index()
        {
            return View();
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
                    return RedirectToAction("StoreFront", _store);
                }
            }
            return View();
        }

        public IActionResult StoreFront()
        {
            return View(_store);
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
