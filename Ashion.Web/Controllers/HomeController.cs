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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}