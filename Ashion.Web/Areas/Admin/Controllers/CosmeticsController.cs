using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Areas.Admin.Controllers
{
    public class CosmeticsController : AdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
