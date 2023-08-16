using Ashion.Core.Contracts;
using Ashion.Web.Areas.Admin.Models.Accessories;
using Ashion.Web.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Areas.Admin.Controllers
{
    public class AccessoriesController : AdminController
    {
        private readonly IAccessoriesService accessories;
        private readonly IMapper mapper;

        public AccessoriesController(
            IAccessoriesService accessories,
            IMapper mapper)
        {
            this.accessories = accessories;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View(new AccessoryFormModel()
            {
                Categories = await this.accessories.AllCategories(),
            });
        }

        [HttpPost]
        public async Task<IActionResult> Add(AccessoryFormModel model)
        {
            if (!(await this.accessories.CategoryExists(model.CategoryId)))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.accessories.AllCategories();

                return View(model);
            }

            var newAccessoryId = await this.accessories.Create(model.Name, model.Brand, model.Price,
                model.ShortContent, model.Description, model.Quantity, model.CategoryId, model.ImageUrls);

            return RedirectToAction("Details", "Accessory", new { id = newAccessoryId, information = model.GetInformation(), area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!(await this.accessories.Exists(id)))
            {
                return BadRequest();
            }

            var accessory = await this.accessories.AccessoryDetailsById(id);

            var accessoryCategoryId = await this.accessories.GetAccessoryCategoryId(id);

            var accessoryModel = this.mapper.Map<AccessoryFormModel>(accessory);
            accessoryModel.CategoryId = accessoryCategoryId;
            accessoryModel.Categories = await this.accessories.AllCategories();

            return View(accessoryModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, AccessoryFormModel model)
        {
            if (!(await this.accessories.Exists(id)))
            {
                return this.View();
            }

            if (!(await this.accessories.CategoryExists(model.CategoryId)))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId),
                    "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await this.accessories.AllCategories();

                return View(model);
            }

            await this.accessories.Edit(id, model.Name, model.Brand, model.Price, model.ShortContent,
                model.Description, model.Quantity, model.CategoryId, model.ImageUrls);

            return RedirectToAction("Details", "Accessories", new { id, information = model.GetInformation(), area = "" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!(await this.accessories.Exists(id)))
            {
                return BadRequest();
            }

            var accessory = await this.accessories.AccessoryDetailsById(id);

            var model = this.mapper.Map<AccessoryDetailsViewModel>(accessory);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(AccessoryDetailsViewModel model)
        {
            if (!(await this.accessories.Exists(model.Id)))
            {
                return BadRequest();
            }

            await this.accessories.Delete(model.Id);

            return RedirectToAction("Accessories", "Shop", new { area = "" });
        }
    }
}
