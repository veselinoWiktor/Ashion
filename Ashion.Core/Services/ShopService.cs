using Ashion.Core.Contracts;
using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Ashion.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Core.Services
{
    public class ShopService : IShopService
    {
        private readonly IRepository repository;

        
        public ShopService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ShopProductServiceModel>> GetAllAccesories()
        {
            return await this.repository.AllReadonly<Accessory>()
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price
                }).ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllColors()
        {
            return await this.repository.AllReadonly<Color>()
                .OrderBy(c => c.Id)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<ShopProductServiceModel>> GetAllCosmetics()
        {
            return await this.repository.AllReadonly<Cosmetic>()
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price
                }).ToListAsync();
        }

        public async Task<IEnumerable<ShopProductServiceModel>> GetAllKidsClothes()
        {
            return await this.repository.AllReadonly<ClothColor>()
                .Where(cc => cc.Cloth.ForKids == true)
                .Select(cc => new ShopProductServiceModel()
                {
                    Id = cc.ClothId,
                    Name = cc.Cloth.Name,
                    Brand = cc.Cloth.Brand,
                    ImageUrl = cc.Cloth.Images.Where(i => i.ClothColorId == cc.ColorId).First().Url,
                    Price = cc.Cloth.Price,
                }).ToListAsync();
        }

        public async Task<IEnumerable<ShopProductServiceModel>> GetAllMensClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 300,
            int currentPage = 1,
            int productsPerPage = 9)
        {
            var menClothesQuery = this.repository.AllReadonly<ClothColor>()
                .Where(cc => cc.Cloth.Gender == Gender.Male 
                && cc.Cloth.ForKids == false 
                && cc.Cloth.Price > minPrice 
                && cc.Cloth.Price < maxPrice)
                .AsQueryable();

            if (!String.IsNullOrWhiteSpace(category))
            {
                menClothesQuery = menClothesQuery.Where(cc => cc.Cloth.Category.Name.ToLower() == category.ToLower());
            }

            if (sizes != null)
            {
                var validSizes = sizes.Where(s => !String.IsNullOrWhiteSpace(s)).Select(c => c.ToLower()).ToList();

                menClothesQuery = menClothesQuery
                    .Where(cc => cc.Cloth.Sizes.Any(cs => validSizes.Contains(cs.Size.SizeNumber.ToLower())));
            }

            if (colors != null)
            {
                var validColors = colors.Where(c => !String.IsNullOrWhiteSpace(c)).Select(c => c.ToLower()).ToList();

                menClothesQuery = menClothesQuery
                    .Where(cc => validColors.Contains(cc.Color.Name.ToLower()));
            }

            var mensClothes = await menClothesQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(cc => new ShopProductServiceModel()
                {
                    Id = cc.ClothId,
                    Name = cc.Cloth.Name,
                    Brand = cc.Cloth.Brand,
                    ImageUrl = cc.Cloth.Images.Where(i => i.ClothColorId == cc.ColorId).First().Url,
                    Price = cc.Cloth.Price,
                })
                .ToListAsync();


            return mensClothes; 
        }

        public async Task<IEnumerable<ShopProductServiceModel>> GetAllProducts(
            string? category = null,
            string? size = null,
            string? color = null,
            int minPrice = 0,
            int maxPrice = 10000,
            int currentPage = 1,
            int productsPerPage = 1)
        {
            var allProducts = new List<ShopProductServiceModel>();

            var allMensClothes = await this.GetAllMensClothes();
            var allWomensClothes = await this.GetAllWomensClothes();
            var allKidsClothes = await this.GetAllKidsClothes();
            var allAccessories = await this.GetAllAccesories();
            var allCosmetics = await this.GetAllCosmetics();

            allProducts.AddRange(allMensClothes);
            allProducts.AddRange(allWomensClothes);
            allProducts.AddRange(allKidsClothes);
            allProducts.AddRange(allAccessories);
            allProducts.AddRange(allCosmetics);

            allProducts.Shuffle();

            return allProducts;
        }

        public async Task<IEnumerable<string>> GetAllSizes()
        {
            return await this.repository.AllReadonly<Size>()
                .OrderBy(s => s.Id)
                .Select(s => s.SizeNumber)
                .ToListAsync();
        }

        public async Task<IEnumerable<ShopProductServiceModel>> GetAllWomensClothes()
        {
            return await this.repository.AllReadonly<ClothColor>()
                .Where(cc => cc.Cloth.Gender == Gender.Female && cc.Cloth.ForKids == false)
                .Select(cc => new ShopProductServiceModel()
                {
                    Id = cc.ClothId,
                    Name = cc.Cloth.Name,
                    Brand = cc.Cloth.Brand,
                    ImageUrl = cc.Cloth.Images.Where(i => i.ClothColorId == cc.ColorId).First().Url,
                    Price = cc.Cloth.Price,
                }).ToListAsync();
        }

        public async Task<HomeIndexServiceModel> GetCountInformation()
        {
            var mensCount = await repository.AllReadonly<ClothColor>()
                .Where(cc => cc.Cloth.Gender == Gender.Male)
                .CountAsync();

            var kidsCount = await repository.AllReadonly<ClothColor>()
                .Where(cc => cc.Cloth.ForKids == true)
                .CountAsync();

            var cosmeticsCount = await repository.AllReadonly<Cosmetic>()
                .CountAsync();

            var accessoriesCount = await repository.AllReadonly<Accessory>()
                .CountAsync();

            return new HomeIndexServiceModel()
            {
                MensClothsCount = mensCount,
                KidsClothsCount = kidsCount,
                CosmeticsCount = cosmeticsCount,
                AccessoriesCount = accessoriesCount,
            };
        }

    }
}
