using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        public IActionResult All()
        {
            return View();
        }

        public IActionResult Womens()
        {
            return View();
        }

        public IActionResult Mens()
        {
            return View();
        }
        public IActionResult Kids()
        {
            return View();
        }

        public IActionResult Accessories()
        {
            return View();
        }
        public IActionResult Cosmetics()
        {
            return View();
        }
    }
}
