using Ashion.Core.Contracts;
using Ashion.Web.Areas.Admin.Models.Clothes;
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
        public IActionResult All()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new ClothFormModel()
            {
                Categories = await this.clothes.AllCategories(),
                Colors = await this.clothes.AllColors(),
                Sizes = await this.clothes.AllSizes(),
                ImageUrls = new List<string>() { "asd", "bsd", "vsd"}
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

            var newClothId = await this.clothes.Create(model.Name, model.Brand, model.Price,
                model.ShortContent, model.Description, model.Quantity, model.CategoryId, model.ColorId,
                model.Gender, model.ForKids, model.ImageUrls, model.SizesIds);

            return RedirectToAction("Details", "Clothes", new { id = newClothId, area = "" });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            //if (!(await this.clothes.Exists(id)))
            //{
            //    return BadRequest();
            //}

            //var cloth = await this.c

            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, ClothFormModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
