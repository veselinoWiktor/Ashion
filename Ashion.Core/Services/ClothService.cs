using Ashion.Core.Contracts;
using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.ProductsShared;
using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Ashion.Web.Extensions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Core.Services
{
    public class ClothService : IClothService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public ClothService(
            IRepository repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ProductCategoryServiceModel>> AllCategories()
        {
            return await this.repository.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Cloth)
                .ProjectTo<ProductCategoryServiceModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<ClothColorServiceModel>> AllColors()
        {
            return await this.repository.AllReadonly<Color>()
                .ProjectTo<ClothColorServiceModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<ClothSizeServiceModel>> AllSizes()
        {
            return await this.repository.AllReadonly<Size>()
                .ProjectTo<ClothSizeServiceModel>(this.mapper.ConfigurationProvider)
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
                    Price = c.Price,
                    InStock = c.InStock,
                    FashionType = c.ForKids ? "Kids" : c.Gender.ToString(),
                    MainColor = c.Color.Name,
                    Sizes = c.Sizes.Select(s => s.Size.SizeNumber),
                    ImageUrls = c.Images.Select(i => i.Url),
                    OtherColors = this.repository
                        .AllReadonly<Cloth>()
                        .Where(cl => cl.PackageId == c.PackageId && cl.ColorId != c.ColorId)
                        .Select(cl => new ClothColorDetailsServiceModel() { Name = cl.Color.Name, ClothId = cl.Id })
                        .ToList(),
                })
                .FirstAsync();
        }

        public async Task<ClothServiceModel> ClothDetailsForEditById(int id)
        {
            return await this.repository.AllReadonly<Cloth>()
               .Where(c => c.Id == id)
               .ProjectTo<ClothServiceModel>(this.mapper.ConfigurationProvider)
               .FirstAsync();
        }

        public async Task<bool> ColorExists(int colorId)
        {
            return await this.repository.AllReadonly<Color>()
                .AnyAsync(c => c.Id == colorId);
        }

        public async Task<int> Create(string name, string brand, decimal price, string packageId,
            string? shortContent, string description, int qunatity,
            int categoryId, int colorId, Gender gender, bool forKids,
            IEnumerable<string> imageUrls, IEnumerable<int> sizeIds)
        {
            var cloth = new Cloth()
            {
                PackageId = packageId,
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

        public async Task Edit(int clothId, string name, string brand,
            decimal price, string packageId, string? shortContent, string description,
            int qunatity, int categoryId, int colorId, Gender gender,
            bool forKids, IEnumerable<string> imageUrls, IEnumerable<int> sizeIds)
        {
            var cloth = await this.repository.All<Cloth>()
                .Where(c => c.Id == clothId)
                .Include(c => c.Images)
                .Include(c => c.Sizes)
                .ThenInclude(cs => cs.Size)
                .FirstAsync();

            cloth.PackageId = packageId;
            cloth.Name = name;
            cloth.Brand = brand;
            cloth.Price = price;
            cloth.ShortContent = shortContent;
            cloth.Description = description;
            cloth.Quantity = qunatity;
            cloth.CategoryId = categoryId;
            cloth.ColorId = colorId;
            cloth.Gender = gender;
            cloth.ForKids = forKids;

            var imageIds = cloth.Images.Select(i => i.Id).ToList();

            foreach (var imageId in imageIds)
            {
                await this.repository.DeleteAsync<Image>(imageId);
            }

            var currentSizeIds = cloth.Sizes.Select(cs => cs.SizeId).ToList();

            foreach (var sizeId in currentSizeIds)
            {
                var clothSize = await this.repository.GetByIdsAsync<ClothSize>(new object[] { clothId, sizeId });

                this.repository.Delete<ClothSize>(clothSize);
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

            foreach (var sizeId in sizeIds)
            {
                var clothSize = new ClothSize()
                {
                    ClothId = clothId,
                    SizeId = sizeId,
                };

                await this.repository.AddAsync(clothSize);
            }

            await this.repository.SaveChangesAsync();
        }

        public async Task<string> Delete(int clothId)
        {
            var cloth = await this.repository.All<Cloth>()
                .Where(c => c.Id == clothId)
                .Include(c => c.Images)
                .Include(c => c.Sizes)
                .FirstAsync();



            foreach (var image in cloth.Images)
            {
                this.repository.Delete<Image>(image);
            }

            foreach (var clothSize in cloth.Sizes)
            {
                this.repository.Delete<ClothSize>(clothSize);
            }

            this.repository.Delete<Cloth>(cloth);
            await this.repository.SaveChangesAsync();

            if (cloth.ForKids == true)
            {
                return "Kids";
            }
            else if (cloth.Gender == Gender.Male)
            {
                return "Mens";
            }
            else
            {
                return "Womens";
            }
        }

        public async Task<string> GetInformationByClothId(int id)
        {
            var cloth = await this.repository.AllReadonly<Cloth>()
                .Where(c => c.Id == id)
                .ProjectTo<ShopProductServiceModel>(this.mapper.ConfigurationProvider)
                .FirstAsync();

            return cloth.GetInformation();
        }
    }
}
