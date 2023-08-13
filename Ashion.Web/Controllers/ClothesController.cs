using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class ClothesController : Controller
    {
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
