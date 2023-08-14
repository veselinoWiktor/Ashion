using Ashion.Core.Models.Accessory;
using Ashion.Core.Models.Cosmetics;
using Ashion.Core.Models.ProductsShared;

namespace Ashion.Core.Contracts
{
    public interface ICosmeticsService
    {
        Task<IEnumerable<ProductCategoryServiceModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(string name, string brand, decimal price,
            string? shortContent, string description, string ingredients,
            int qunatity, int categoryId, IEnumerable<string> imageUrls);

        Task<bool> Exists(int id);

        Task<CosmeticDetailsServiceModel> CosmeticDetailsById(int id);

        Task<int> GetCosmeticCategoryId(int comseticId);

        Task Edit(int cosmeticId, string name, string brand, decimal price,
            string? shortContent, string description, string ingredients, int qunatity,
            int categoryId, IEnumerable<string> imageUrls);

        Task Delete(int cosmeticId);
    }
}
