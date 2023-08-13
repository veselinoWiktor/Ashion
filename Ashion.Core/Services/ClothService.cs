using Ashion.Core.Contracts;
using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Core.Services
{
    public class ClothService : IClothService
    {
        private readonly IRepository repository;

        public ClothService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ProductCategoryServiceModel>> AllCategories()
        {
            return await this.repository.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Cloth)
                .Select(c => new ProductCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ClothColorServiceModel>> AllColors()
        {
            return await this.repository.AllReadonly<Color>()
                .Select(c => new ClothColorServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ClothSizeServiceModel>> AllSizes()
        {
            return await this.repository.AllReadonly<Size>()
                .Select(c => new ClothSizeServiceModel()
                {
                    Id = c.Id,
                    SizeNumber = c.SizeNumber
                })
                .ToListAsync();
        }

        public async Task<bool> AllSizesExists(IEnumerable<int> sizesIds)
        {
            var result = true;

            foreach (var sizeId in sizesIds)
            {
                if (!(await repository.AllReadonly<Size>().AnyAsync(s => s.Id == sizeId)))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await this.repository.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<ClothDetailsServiceModel> ClothDetailsById(int id)
        {
            return await this.repository.AllReadonly<Cloth>()
                .Where(c => c.Id == id)
                .Select(c => new ClothDetailsServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Brand = c.Brand,
                    ShortContent = c.ShortContent,
                    Description = c.Description,
                    FashionType = c.ForKids ? "Kids" : c.Gender.ToString(),
                    Price = c.Price,
                    InStock = c.InStock,
                    MainColor = new ClothColorServiceModel() { Id = c.ColorId, Name = c.Color.Name },
                    ImageUrls = c.Images
                        .Select(i => i.Url)
                        .ToList(),
                    Sizes = c.Sizes
                        .Select(s => new ClothSizeServiceModel() { Id = s.Size.Id, SizeNumber = s.Size.SizeNumber })
                        .ToList(),
                    OtherColors = this.repository
                        .AllReadonly<Cloth>()
                        .Where(cl => cl.PackageId == c.PackageId && cl.ColorId != c.ColorId)
                        .Select(cl => new ClothColorDetailsServiceModel() { Id = cl.ColorId, Name = cl.Color.Name, ClothId = cl.Id })
                        .ToList()
                })
                .FirstAsync();
        }

        public async Task<bool> ColorExists(int colorId)
        {
            return await this.repository.AllReadonly<Color>()
                .AnyAsync(c => c.Id == colorId);
        }

        public async Task<int> Create(string name, string brand, decimal price,
            string? shortContent, string description, int qunatity,
            int categoryId, int colorId, Gender gender, bool forKids,
            IEnumerable<string> imageUrls, IEnumerable<int> sizeIds)
        {
            var cloth = new Cloth()
            {
                PackageId = (new Guid()).ToString(),
                Name = name,
                Brand = brand,
                Price = price,
                ShortContent = shortContent,
                Description = description,
                Quantity = qunatity,
                CategoryId = categoryId,
                ColorId = colorId,
                Gender = gender,
                ForKids = forKids,
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

            cloth.Images = images;

            await this.repository.AddAsync(cloth);
            await this.repository.SaveChangesAsync();

            foreach (var sizeId in sizeIds)
            {
                var clothSize = new ClothSize()
                {
                    ClothId = cloth.Id,
                    SizeId = sizeId,
                };

                await this.repository.AddAsync(clothSize);
            }

            await repository.SaveChangesAsync();

            return cloth.Id;
        }

        public async Task<bool> Exists(int id)
        {
            return await this.repository.AllReadonly<Cloth>().AnyAsync(c => c.Id == id); 
        }
    }
}
