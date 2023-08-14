using Ashion.Core.Contracts;
using Ashion.Web.Areas.Admin.Models.Accessories;
using Ashion.Web.Areas.Admin.Models.Cosmetics;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Areas.Admin.Controllers
{
    public class CosmeticsController : AdminController
    {
        private readonly ICosmeticsService cosmetics;

        public CosmeticsController(ICosmeticsService cosmetics)
        {
            this.cosmetics = cosmetics;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new CosmeticFormModel()
            {
                Categories = await this.cosmetics.AllCategories(),
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(CosmeticFormModel model)
        {
            if (!(await this.cosmetics.CategoryExists(model.CategoryId)))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.cosmetics.AllCategories();

                return View(model);
            }

            var newCosmeticId = await this.cosmetics.Create(model.Name, model.Brand, model.Price,
                model.ShortContent, model.Description, model.Ingredients, model.Quantity, model.CategoryId, model.ImageUrls);

            return RedirectToAction("Details", "Cosmetics", new { id = newCosmeticId, information = model.GetInformation(), area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!(await this.cosmetics.Exists(id)))
            {
                return BadRequest();
            }

            var cosmetic = await this.cosmetics.CosmeticDetailsById(id);

            var cosmeticCategoryId = await this.cosmetics.GetCosmeticCategoryId(id);

            var comseticModel = new CosmeticFormModel()
            {
                Name = cosmetic.Name,
                Brand = cosmetic.Brand,
                ShortContent = cosmetic.ShortContent,
                Description = cosmetic.Description,
                Ingredients = cosmetic.Ingredients,
                Price = cosmetic.Price,
                Quantity = cosmetic.Quantity,
                ImageUrls = cosmetic.ImageUrls,
                CategoryId = cosmeticCategoryId,
                Categories = await this.cosmetics.AllCategories(),
            };

            return View(comseticModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CosmeticFormModel model)
        {
            if (!(await this.cosmetics.Exists(id)))
            {
                return this.View();
            }

            if (!(await this.cosmetics.CategoryExists(model.CategoryId)))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.cosmetics.AllCategories();

                return View(model);
            }

            await this.cosmetics.Edit(id, model.Name, model.Brand, model.Price, model.ShortContent,
                model.Description, model.Ingredients, model.Quantity, model.CategoryId, model.ImageUrls);

            return RedirectToAction("Details", "Cosmetics", new { id, information = model.GetInformation(), area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!(await this.cosmetics.Exists(id)))
            {
                return BadRequest();
            }

            var cosmetic = await this.cosmetics.CosmeticDetailsById(id);

            var model = new CosmeticDetailsViewModel()
            {
                Id = cosmetic.Id,
                Name = cosmetic.Name,
                Brand = cosmetic.Brand,
                ImageUrl = cosmetic.ImageUrls.First(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CosmeticDetailsViewModel model)
        {
            if (!(await this.cosmetics.Exists(model.Id)))
            {
                return BadRequest();
            }

            await this.cosmetics.Delete(model.Id);

            return RedirectToAction("Cosmetics", "Shop", new { area = "" });
        }
    }
}
