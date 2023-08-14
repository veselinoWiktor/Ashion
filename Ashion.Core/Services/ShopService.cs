using Ashion.Core.Contracts;
using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Ashion.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Ashion.Core.Services
{
    public class ShopService : IShopService
    {
        private readonly IRepository repository;

        
        public ShopService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ShopQueryServiceModel> GetAllAccesories(
            string? category = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9)
        {
            var accessoriesQuery = this.repository.AllReadonly<Accessory>()
                .Where(a => a.Price > minPrice
                && a.Price < maxPrice)
                .AsQueryable();

            if (!String.IsNullOrWhiteSpace(category))
            {
                accessoriesQuery = accessoriesQuery.Where(a => a.Category.Name.ToLower() == category.ToLower());
            }

            var accessories = await accessoriesQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    Description = c.Description,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price,
                })
                .ToListAsync();

            var totalProductsCount = await accessoriesQuery.CountAsync();

            return new ShopQueryServiceModel()
            {
                Products = accessories,
                TotalProductsCount = totalProductsCount
            };
        }

        

        public async Task<ShopQueryServiceModel> GetAllCosmetics(
            string? category = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9)
        {
            var cosmeticsQuery = this.repository.AllReadonly<Cosmetic>()
                .Where(c => c.Price > minPrice
                && c.Price < maxPrice)
                .AsQueryable();

            if (!String.IsNullOrWhiteSpace(category))
            {
                cosmeticsQuery = cosmeticsQuery.Where(c => c.Category.Name.ToLower() == category.ToLower());
            }

            var cosmetics = await cosmeticsQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    Description = c.Description,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price,
                })
                .ToListAsync();

            var totalProductsCount = await cosmeticsQuery.CountAsync();

            return new ShopQueryServiceModel()
            {
                Products = cosmetics,
                TotalProductsCount = totalProductsCount
            };
        }

        public async Task<ShopQueryServiceModel> GetAllKidsClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9)
        {
            var kidsClothesQuery = this.repository.AllReadonly<Cloth>()
                .Where(c => c.ForKids == true
                && c.Price > minPrice
                && c.Price < maxPrice)
                .AsQueryable();

            if (!String.IsNullOrWhiteSpace(category))
            {
                kidsClothesQuery = kidsClothesQuery.Where(cc => cc.Category.Name.ToLower() == category.ToLower());
            }

            if (sizes != null)
            {
                var validSizes = sizes.Where(s => !String.IsNullOrWhiteSpace(s)).Select(c => c.ToLower()).ToList();

                kidsClothesQuery = kidsClothesQuery
                    .Where(c => c.Sizes.Any(cs => validSizes.Contains(cs.Size.SizeNumber.ToLower())));
            }

            if (colors != null)
            {
                var validColors = colors.Where(c => !String.IsNullOrWhiteSpace(c)).Select(c => c.ToLower()).ToList();

                kidsClothesQuery = kidsClothesQuery
                    .Where(c => validColors.Contains(c.Color.Name.ToLower()));
            }

            var kidsClothes = await kidsClothesQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    Description = c.Description,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price,
                })
                .ToListAsync();

            var totalProductsCount = await kidsClothesQuery.CountAsync();

            return new ShopQueryServiceModel()
            {
                Products = kidsClothes,
                TotalProductsCount = totalProductsCount
            };
        }

        public async Task<ShopQueryServiceModel> GetAllMensClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9)
        {
            var menClothesQuery = this.repository.AllReadonly<Cloth>()
                .Where(c => c.Gender == Gender.Male 
                && c.ForKids == false 
                && c.Price > minPrice 
                && c.Price < maxPrice)
                .AsQueryable();

            if (!String.IsNullOrWhiteSpace(category))
            {
                menClothesQuery = menClothesQuery.Where(c => c.Category.Name.ToLower() == category.ToLower());
            }

            if (sizes != null)
            {
                var validSizes = sizes.Where(s => !String.IsNullOrWhiteSpace(s)).Select(c => c.ToLower()).ToList();

                menClothesQuery = menClothesQuery
                    .Where(c => c.Sizes.Any(cs => validSizes.Contains(cs.Size.SizeNumber.ToLower())));
            }

            if (colors != null)
            {
                var validColors = colors.Where(c => !String.IsNullOrWhiteSpace(c)).Select(c => c.ToLower()).ToList();

                menClothesQuery = menClothesQuery
                    .Where(c => validColors.Contains(c.Color.Name.ToLower()));
            }

            var mensClothes = await menClothesQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    Description = c.Description,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price,
                })
                .ToListAsync();

            var totalProductsCount = await menClothesQuery.CountAsync();

            return new ShopQueryServiceModel()
            {
                Products = mensClothes,
                TotalProductsCount = totalProductsCount
            }; 
        }

        public async Task<ShopQueryServiceModel> GetAllWomensClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9)
        {
            var womenClothesQuery = this.repository.AllReadonly<Cloth>()
                .Where(c => c.Gender == Gender.Female
                && c.ForKids == false
                && c.Price > minPrice
                && c.Price < maxPrice)
                .AsQueryable();

            if (!String.IsNullOrWhiteSpace(category))
            {
                womenClothesQuery = womenClothesQuery.Where(c => c.Category.Name.ToLower() == category.ToLower());
            }

            if (sizes != null)
            {
                var validSizes = sizes.Where(s => !String.IsNullOrWhiteSpace(s)).Select(c => c.ToLower()).ToList();

                womenClothesQuery = womenClothesQuery
                    .Where(c => c.Sizes.Any(cs => validSizes.Contains(cs.Size.SizeNumber.ToLower())));
            }

            if (colors != null)
            {
                var validColors = colors.Where(c => !String.IsNullOrWhiteSpace(c)).Select(c => c.ToLower()).ToList();

                womenClothesQuery = womenClothesQuery
                    .Where(c => validColors.Contains(c.Color.Name.ToLower()));
            }

            var womensClothes = await womenClothesQuery
                .Skip((currentPage - 1) * productsPerPage)
                .Take(productsPerPage)
                .Select(c => new ShopProductServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    Description = c.Description,
                    ImageUrl = c.Images.First().Url,
                    Price = c.Price,
                })
                .ToListAsync();

            var totalProductsCount = await womenClothesQuery.CountAsync();

            return new ShopQueryServiceModel()
            {
                Products = womensClothes,
                TotalProductsCount = totalProductsCount
            };
        }

        public async Task<HomeIndexServiceModel> GetCountInformation()
        {
            var mensCount = await repository.AllReadonly<Cloth>()
                .Where(cc => cc.Gender == Gender.Male)
                .CountAsync();

            var kidsCount = await repository.AllReadonly<Cloth>()
                .Where(cc => cc.ForKids == true)
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

        public async Task<IEnumerable<string>> GetAllSizes()
        {
            return await this.repository.AllReadonly<Size>()
                .OrderBy(s => s.Id)
                .Select(s => s.SizeNumber)
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> GetAllColors()
        {
            return await this.repository.AllReadonly<Color>()
                .OrderBy(c => c.Id)
                .Select(c => c.Name)
                .ToListAsync();
        }
    }
}
