using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class ClothesController : Controller
    {
        private readonly IClothService clothes;
        private readonly IReviewService reviews;

        public ClothesController(
            IClothService clothes,
            IReviewService reviews)
        {
            this.clothes = clothes;
            this.reviews = reviews;
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

            clothModel.Reviews = await this.reviews.GetClothReviews(id);

            return View(clothModel);
        }
    }
}
