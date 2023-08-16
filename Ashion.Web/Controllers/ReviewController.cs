using Ashion.Core.Contracts;
using Ashion.Web.Extensions;
using Ashion.Web.Models.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    [Authorize]
    public class ReviewController : Controller
    {
        private readonly IReviewService reviews;

        public ReviewController(IReviewService reviews)
        {
            this.reviews = reviews;
        }

        [HttpGet]
        public IActionResult AddToAccessory(int id)
        {
            return View("Views/Review/Add.cshtml", new ReviewFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddToAccessory(int id, ReviewFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var information = await this.reviews.CreateAccessoryReview(id, model.Title, model.Content, this.User.Id());

            return RedirectToAction("Details", "Accessories", new { id, information });
        }

        [HttpGet]
        public IActionResult AddToCloth(int id)
        {
            return View("Views/Review/Add.cshtml", new ReviewFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddToCloth(int id, ReviewFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var information = await this.reviews.CreateClothReview(id, model.Title, model.Content, this.User.Id());

            return RedirectToAction("Details", "Clothes", new { id, information });
        }

        [HttpGet]
        public IActionResult AddToCosmetic()
        {
            return View("Views/Review/Add.cshtml", new ReviewFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> AddToCosmetic(int id, ReviewFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var information = await this.reviews.CreateCosmeticReview(id, model.Title, model.Content, this.User.Id());

            return RedirectToAction("Details", "Cosmetics", new { id, information });
        }
    }
}
