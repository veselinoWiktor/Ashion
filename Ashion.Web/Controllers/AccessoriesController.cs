using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    public class AccessoriesController : Controller
    {
        private readonly IAccessoriesService accessories;
        private readonly IReviewService reviews;

        public AccessoriesController(
            IAccessoriesService accessories,
            IReviewService reviews)
        {
            this.accessories = accessories;
            this.reviews = reviews;
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

                accessoryModel.Reviews = await this.reviews.GetAccessoryReviews(id);

            return View(accessoryModel);
        }
    }
}
