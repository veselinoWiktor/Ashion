using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class CosmeticsController : Controller
    {
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
