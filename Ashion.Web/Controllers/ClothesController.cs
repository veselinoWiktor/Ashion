using Ashion.Core.Contracts;
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

        public async Task<IActionResult> Details(int id)
        {
            if (!(await clothes.Exists(id)))
            {
                return BadRequest();
            }

            var clothModel = await this.clothes.ClothDetailsById(id);

            return View(clothModel);
        }
    }
}
