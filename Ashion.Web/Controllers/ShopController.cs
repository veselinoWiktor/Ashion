using Ashion.Core.Contracts;
using Ashion.Infrastructure.Extensions;
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
        public async Task<IActionResult> Womens([FromQuery]ShopQueryModel query)
        {
            var sizes = query.Sizes?.Split(',').ToArray();
            var colors = query.Colors?.Split(',').ToArray();
            var queryResult = await shop.GetAllWomensClothes(query.Category, sizes, colors, query.MinPriceRange, query.MaxPriceRange, query.CurrentPage, ShopQueryModel.ProductsPerPage);

            query.Products = queryResult.Products;
            query.TotalProductsCount = queryResult.TotalProductsCount;

            query.AllColors = await shop.GetAllColors();
            query.AllSizes = await shop.GetAllSizes();

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Mens([FromQuery]ShopQueryModel query)
        {
            var sizes = query.Sizes?.Split(',').ToArray();
            var colors = query.Colors?.Split(',').ToArray();
            var queryResult = await shop.GetAllMensClothes(query.Category, sizes, colors, query.MinPriceRange, query.MaxPriceRange, query.CurrentPage, ShopQueryModel.ProductsPerPage);

            query.Products = queryResult.Products;
            query.TotalProductsCount = queryResult.TotalProductsCount;

            query.AllColors = await shop.GetAllColors();
            query.AllSizes = await shop.GetAllSizes();

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Kids([FromQuery]ShopQueryModel query)
        {
            var sizes = query.Sizes?.Split(',').ToArray();
            var colors = query.Colors?.Split(',').ToArray();
            var queryResult = await shop.GetAllKidsClothes(query.Category, sizes, colors, query.MinPriceRange, query.MaxPriceRange, query.CurrentPage, ShopQueryModel.ProductsPerPage);

            query.Products = queryResult.Products;
            query.TotalProductsCount = queryResult.TotalProductsCount;

            query.AllColors = await shop.GetAllColors();
            query.AllSizes = await shop.GetAllSizes();

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Accessories([FromQuery]ShopQueryModel query)
        {
            var queryResult = await shop.GetAllAccesories(query.Category, query.MinPriceRange, query.MaxPriceRange, query.CurrentPage, ShopQueryModel.ProductsPerPage);

            query.Products = queryResult.Products;
            query.TotalProductsCount = queryResult.TotalProductsCount;

            return View(query);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Cosmetics([FromQuery]ShopQueryModel query)
        {
            var queryResult = await shop.GetAllCosmetics(query.Category, query.MinPriceRange, query.MaxPriceRange, query.CurrentPage, ShopQueryModel.ProductsPerPage);

            query.Products = queryResult.Products;
            query.TotalProductsCount = queryResult.TotalProductsCount;

            return View(query);
        }
    }
}
