using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.ProductsShared;
using Ashion.Core.Models.Shop;
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

        Task<int> Create(string name, string brand, decimal price, string packageId,
            string? shortContent, string description, int qunatity,
            int categoryId, int colorId, Gender gender, bool forKids,
            IEnumerable<string> imageUrls, IEnumerable<int> sizeIds);

        Task<bool> Exists(int id);

        Task<ClothDetailsServiceModel> ClothDetailsById(int id);

        Task<ClothServiceModel> ClothDetailsForEditById(int id);

        Task Edit(int clothId, string name, string brand, decimal price, string packageId,
            string? shortContent, string description, int qunatity,
            int categoryId, int colorId, Gender gender, bool forKids,
            IEnumerable<string> imageUrls, IEnumerable<int> sizeIds);

        Task<string> Delete(int clothId);

        Task<ShopProductServiceModel> GetClothById(int id);
    }
}
