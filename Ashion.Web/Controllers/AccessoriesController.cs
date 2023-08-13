using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class AccessoriesController : Controller
    {
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
