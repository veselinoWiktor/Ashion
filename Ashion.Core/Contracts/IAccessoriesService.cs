using Ashion.Core.Models.Accessory;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Data.Enums;

namespace Ashion.Core.Contracts
{
    public interface IAccessoriesService
    {
        Task<IEnumerable<ProductCategoryServiceModel>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(string name, string brand, decimal price,
            string? shortContent, string description, int qunatity,
            int categoryId, IEnumerable<string> imageUrls);

        Task<bool> Exists(int id);

        Task<AccessoryDetailsServiceModel> AccessoryDetailsById(int id);

        Task<int> GetAccessoryCategoryId(int accessoryId);

        Task Edit(int accessoryId, string name, string brand, decimal price,
            string? shortContent, string description, int qunatity,
            int categoryId, IEnumerable<string> imageUrls);

        Task Delete(int accessoryId);
    }
}
