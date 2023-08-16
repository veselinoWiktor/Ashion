using Ashion.Core.Contracts;
using Ashion.Core.Models.Accessory;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Core.Services
{
    public class AccessoriesService : IAccessoriesService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public AccessoriesService(
            IRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProductCategoryServiceModel>> AllCategories()
        {
            return await this.repository.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Accessory)
                .ProjectTo<ProductCategoryServiceModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await this.repository.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> Create(string name, string brand, 
            decimal price, string? shortContent, string description, 
            int qunatity, int categoryId, IEnumerable<string> imageUrls)
        {
            var accessory = new Accessory()
            {
                Name = name,
                Brand = brand,
                Price = price,
                ShortContent = shortContent,
                Description = description,
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

            accessory.Images = images;

            await this.repository.AddAsync(accessory);
            await repository.SaveChangesAsync();

            return accessory.Id;
        }

        public async Task<bool> Exists(int id)
        {
            return await this.repository.AllReadonly<Accessory>().AnyAsync(c => c.Id == id);
        }

        public async Task<AccessoryDetailsServiceModel> AccessoryDetailsById(int id)
        {
            return await this.repository.AllReadonly<Accessory>()
                .Where(a => a.Id == id)
                .ProjectTo<AccessoryDetailsServiceModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();
        }

        public async Task<int> GetAccessoryCategoryId(int accessoryId)
        {
            return (await this.repository.GetByIdAsync<Accessory>(accessoryId)).CategoryId;
        }

        public async Task Edit(int accessoryId, string name, string brand,
            decimal price, string? shortContent, string description,
            int qunatity, int categoryId, IEnumerable<string> imageUrls)
        {
            var cloth = await this.repository.All<Accessory>()
                .Where(c => c.Id == accessoryId)
                .Include(c => c.Images)
                .FirstAsync();

            cloth.Name = name;
            cloth.Brand = brand;
            cloth.Price = price;
            cloth.ShortContent = shortContent;
            cloth.Description = description;
            cloth.Quantity = qunatity;
            cloth.CategoryId = categoryId;

            var imageIds = cloth.Images.Select(i => i.Id).ToList();

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

            cloth.Images = images;

            await this.repository.SaveChangesAsync();
        }

        public async Task Delete(int accessoryId)
        {
            var accessory = await this.repository.All<Accessory>()
                .Where(c => c.Id == accessoryId)
                .Include(c => c.Images)
                .FirstAsync();


            foreach (var image in accessory.Images)
            {
                this.repository.Delete<Image>(image);
            }

            this.repository.Delete<Accessory>(accessory);
            await this.repository.SaveChangesAsync();
        }
    }
}
