using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
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

        public async Task<IActionResult> Details(int id, string information)
        {
            if (!(await accessories.Exists(id)))
            {
                return BadRequest();
            }

            var accessoryModel = await this.accessories.AccessoryDetailsById(id);

            if (information != accessoryModel.GetInformation())
            {
                return BadRequest();
            }

            return View(accessoryModel);
        }
    }
}
