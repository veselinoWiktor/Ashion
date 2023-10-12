using Ashion.Core.Models.Cart;

namespace Ashion.Core.Contracts
{
    public interface ICartService
    {
        Task<bool> UserHasProductsInCart(string userId);

        Task<IEnumerable<CartProductServiceModel>> GetUserProductsInCart(string userId);

        Task<int> GetUserProductsInCartCount(string userId);
    }
}
