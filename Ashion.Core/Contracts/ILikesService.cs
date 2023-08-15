using Ashion.Core.Models.ProductsShared;

namespace Ashion.Core.Contracts
{
    public interface ILikesService
    {
        Task<LikedProductServiceModel> GetLikedProduct(int id, string type);
    }
}
