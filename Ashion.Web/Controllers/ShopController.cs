using Ashion.Core.Contracts;
using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Web.Models.Shop;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ashion.Web.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private readonly IShopService shop;

        public ShopController(IShopService shop)
        {
            this.shop = shop;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllProducts()
        {
            var allProducts = await shop.GetAllProducts();

            return View(allProducts);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Womens()
        {
            var allWomensClothes = await shop.GetAllWomensClothes();

            return View(allWomensClothes);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Mens([FromQuery] ShopQueryModel query)
        {
            ;
            var queryResult = await shop.GetAllMensClothes(query.Category, query.Size, query.Color, query.MinPriceRange, query.MaxPriceRange, query.CurrentPage, ShopQueryModel.ProductsPerPage);

            query.Products = queryResult;
            query.TotalProductsCount = queryResult.Count();

            query.Colors = await shop.GetAllColors();
            query.Sizes = await shop.GetAllSizes();

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Kids()
        {
            var allKidsClothes = await shop.GetAllKidsClothes();

            return View(allKidsClothes);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Accessories()
        {
            var allAccessories = await shop.GetAllAccesories();

            return View(allAccessories);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Cosmetics()
        {
            var allCosmetics = await shop.GetAllCosmetics();
            return View(allCosmetics);
        }
    }
}
