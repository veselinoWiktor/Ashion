using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using static Ashion.Web.Areas.Admin.AdminConstants;

namespace Ashion.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShopService shop;

        public HomeController(IShopService shop)
        {
            this.shop = shop;
        }

        public async Task<IActionResult> Index()
        {
            if (this.User.IsAdmin())
            {
                return RedirectToAction("Index", "Home", new { area = AreaName });
            }

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