﻿using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Data.Enums;

namespace Ashion.Core.Contracts
{
    public interface IClothService
    {
        Task<IEnumerable<ProductCategoryServiceModel>> AllCategories();

        Task<IEnumerable<ClothColorServiceModel>> AllColors();

        Task<IEnumerable<ClothSizeServiceModel>> AllSizes();

        Task<bool> CategoryExists(int categoryId);

        Task<bool> ColorExists(int colorId);

        Task<bool> AllSizesExists(IEnumerable<int> sizesIds);

        Task<int> Create(string name, string brand, decimal price,
            string? shortContent, string description, int qunatity,
            int categoryId, int colorId, Gender gender, bool forKids,
            IEnumerable<string> imageUrls, IEnumerable<int> sizeIds);
    }
}
