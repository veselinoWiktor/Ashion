using Ashion.Core.Contracts;
using Ashion.Web.Areas.Admin.Models.Clothes;
using Ashion.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Areas.Admin.Controllers
{
    public class ClothesController : AdminController
    {
        private readonly IClothService clothes;

        public ClothesController(IClothService clothes)
        {
            this.clothes = clothes;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new ClothFormModel()
            {
                Categories = await this.clothes.AllCategories(),
                Colors = await this.clothes.AllColors(),
                Sizes = await this.clothes.AllSizes()
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ClothFormModel model)
        {
            if (!(await this.clothes.CategoryExists(model.CategoryId)))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!(await this.clothes.ColorExists(model.ColorId)))
            {
                this.ModelState.AddModelError(nameof(model.ColorId),
                    "Color does not exist.");
            }

            if (!(await this.clothes.AllSizesExists(model.SizesIds)))
            {
                this.ModelState.AddModelError(nameof(model.SizesIds),
                    "Some size/s does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.clothes.AllCategories();
                model.Colors = await this.clothes.AllColors();
                model.Sizes = await this.clothes.AllSizes();

                return View(model);
            }

            var newClothId = await this.clothes.Create(model.Name, model.Brand, model.Price, model.PackageId,
                model.ShortContent, model.Description, model.Quantity, model.CategoryId, model.ColorId,
                model.Gender, model.ForKids, model.ImageUrls, model.SizesIds);

            return RedirectToAction("Details", "Clothes", new { id = newClothId, information = model.GetInformation(), area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!(await this.clothes.Exists(id)))
            {
                return BadRequest();
            }

            var cloth = await this.clothes.ClothDetailsForEditById(id);

            var clothModel = new ClothFormModel()
            {
                PackageId = cloth.PackageId,
                Name = cloth.Name,
                Brand = cloth.Brand,
                ShortContent = cloth.ShortContent,
                Description = cloth.Description,
                Price = cloth.Price,
                Quantity = cloth.Quantity,
                CategoryId = cloth.CategoryId,
                ColorId = cloth.ColorId,
                ForKids = cloth.ForKids,
                Gender = cloth.Gender,
                ImageUrls = cloth.ImageUrls,
                SizesIds = cloth.SizesIds,
                Categories = await this.clothes.AllCategories(),
                Colors = await this.clothes.AllColors(),
                Sizes = await this.clothes.AllSizes(),
            };

            return View(clothModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ClothFormModel model)
        {
            if (!(await this.clothes.Exists(id)))
            {
                return this.View();
            }

            if (!(await this.clothes.CategoryExists(model.CategoryId)))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!(await this.clothes.ColorExists(model.ColorId)))
            {
                this.ModelState.AddModelError(nameof(model.ColorId),
                    "Color does not exist.");
            }

            if (!(await this.clothes.AllSizesExists(model.SizesIds)))
            {
                this.ModelState.AddModelError(nameof(model.SizesIds),
                    "Some size/s does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.clothes.AllCategories();
                model.Colors = await this.clothes.AllColors();
                model.Sizes = await this.clothes.AllSizes();

                return View(model);
            }

            await this.clothes.Edit(id, model.Name, model.Brand, model.Price, model.PackageId, model.ShortContent,
                model.Description, model.Quantity, model.CategoryId, model.ColorId, model.Gender,
                model.ForKids, model.ImageUrls, model.SizesIds);

            return RedirectToAction("Details", "Clothes", new { id, information = model.GetInformation(), area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!(await this.clothes.Exists(id)))
            {
                return BadRequest();
            }

            var cloth = await this.clothes.ClothDetailsForEditById(id);

            var model = new ClothDetailsViewModel()
            {
                Id = cloth.Id,
                Name = cloth.Name,
                Brand = cloth.Brand,
                ImageUrl = cloth.ImageUrls.First(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ClothDetailsViewModel model)
        {
            if (!(await this.clothes.Exists(model.Id)))
            {
                return BadRequest();
            }

            var action = await this.clothes.Delete(model.Id);

            return RedirectToAction(action, "Shop", new { area = "" });
        }
    }
}
