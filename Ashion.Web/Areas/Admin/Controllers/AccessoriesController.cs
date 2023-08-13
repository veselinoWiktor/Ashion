using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Areas.Admin.Controllers
{
    public class AccessoriesController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
