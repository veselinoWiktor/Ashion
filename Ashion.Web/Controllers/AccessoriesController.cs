using Ashion.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class AccessoriesController : Controller
    {
        private readonly IAccessoriesService accessories;

        public AccessoriesController(IAccessoriesService accessories)
        {
            this.accessories = accessories;
        }

        public async Task<IActionResult> Details(int id)
        {
            if (!(await accessories.Exists(id)))
            {
                return BadRequest();
            }

            var accessoryModel = await this.accessories.AccessoryDetailsById(id);

            return View(accessoryModel);
        }
    }
}
