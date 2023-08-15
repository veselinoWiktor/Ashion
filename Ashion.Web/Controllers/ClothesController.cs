using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class ClothesController : Controller
    {
        private readonly IClothService clothes;

        public ClothesController(IClothService clothes)
        {
            this.clothes = clothes;
        }

        public async Task<IActionResult> Details(int id, string information)
        {
            if (!(await clothes.Exists(id)))
            {
                return BadRequest();
            }

            var clothModel = await this.clothes.ClothDetailsById(id);

            if (information != clothModel.GetInformation())
            {
                return BadRequest();
            }

            return View(clothModel);
        }
    }
}
