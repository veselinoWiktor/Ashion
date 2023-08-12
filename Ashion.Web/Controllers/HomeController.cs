using Ashion.Core.Contracts;
using Ashion.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ashion.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShopService shop;

        public HomeController(ILogger<HomeController> logger, IShopService shop)
        {
            _logger = logger;
            this.shop = shop;
        }

        public async Task<IActionResult> Index()
        {
            var model = await shop.GetCountInformation();

            return View(model);
        }

        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }
            if (statusCode == 401)
            {
                return View("Error401");
            }
            return View();
        }
    }
}