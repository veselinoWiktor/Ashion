using Ashion.Core.Contracts;
using Ashion.Core.Models.Cosmetics;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Core.Services
{
    public class CosmeticsService : ICosmeticsService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public CosmeticsService(
            IRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProductCategoryServiceModel>> AllCategories()
        {
            return await this.repository.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Cosmetics)
                .ProjectTo<ProductCategoryServiceModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await this.repository.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> Create(string name, string brand, decimal price,
            string? shortContent, string description, string ingredients,
            int qunatity, int categoryId, IEnumerable<string> imageUrls)
        {
            var cosmetic = new Cosmetic()
            {
                Name = name,
                Brand = brand,
                Price = price,
                ShortContent = shortContent,
                Description = description,
                Ingredients = ingredients,
                Quantity = qunatity,
                CategoryId = categoryId,
                IsActive = true,
            };

            var images = new List<Image>();
            foreach (var imageUrl in imageUrls)
            {
                var image = new Image()
                {
                    Url = imageUrl
                };

                images.Add(image);
            }

            cosmetic.Images = images;

            await this.repository.AddAsync(cosmetic);
            await repository.SaveChangesAsync();

            return cosmetic.Id;
        }

        public async Task<bool> Exists(int id)
        {
            return await this.repository.AllReadonly<Cosmetic>().AnyAsync(c => c.Id == id);
        }

        public async Task<CosmeticDetailsServiceModel> CosmeticDetailsById(int id)
        {
            return await this.repository.AllReadonly<Cosmetic>()
                .Where(a => a.Id == id)
                .ProjectTo<CosmeticDetailsServiceModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> GetCosmeticCategoryId(int cosmeticId)
        {
            return (await this.repository.GetByIdAsync<Cosmetic>(cosmeticId)).CategoryId;
        }

        public async Task Edit(int cosmeticId, string name, string brand,
            decimal price, string? shortContent, string description, string ingredients,
            int qunatity, int categoryId, IEnumerable<string> imageUrls)
        {
            var cosmetic = await this.repository.All<Cosmetic>()
                .Where(c => c.Id == cosmeticId)
                .Include(c => c.Images)
                .FirstAsync();

            cosmetic.Name = name;
            cosmetic.Brand = brand;
            cosmetic.Price = price;
            cosmetic.ShortContent = shortContent;
            cosmetic.Description = description;
            cosmetic.Ingredients = ingredients;
            cosmetic.Quantity = qunatity;
            cosmetic.CategoryId = categoryId;

            var imageIds = cosmetic.Images.Select(i => i.Id).ToList();

            foreach (var imageId in imageIds)
            {
                await this.repository.DeleteAsync<Image>(imageId);
            }

            var images = new List<Image>();
            foreach (var imageUrl in imageUrls)
            {
                var image = new Image()
                {
                    Url = imageUrl
                };

                images.Add(image);
            }

            cosmetic.Images = images;

            await this.repository.SaveChangesAsync();
        }

        public async Task Delete(int cosmeticId)
        {
            var cosmetic = await this.repository.All<Cosmetic>()
                .Where(c => c.Id == cosmeticId)
                .Include(c => c.Images)
                .FirstAsync();


            foreach (var image in cosmetic.Images)
            {
                this.repository.Delete<Image>(image);
            }

            this.repository.Delete<Cosmetic>(cosmetic);
            await this.repository.SaveChangesAsync();
        }
    }
}
