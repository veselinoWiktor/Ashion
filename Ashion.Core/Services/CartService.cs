using Ashion.Core.Contracts;
using Ashion.Core.Models.Cart;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Ashion.Core.Services
{
    public class CartService : ICartService
    {
        private readonly IRepository repository;

        public CartService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<CartProductServiceModel>> GetUserProductsInCart(string userId)
        {
            var userProducts = this.repository.AllReadonly<UserCart>().Where(uc => uc.UserId == userId);
            var productsInCart = new List<CartProductServiceModel>();

            foreach (var productQuery in userProducts)
            {
                var product = productQuery.ProductType switch
                {
                    ProductType.Cloth => await this.repository
                        .AllReadonly<Cloth>()
                        .Where(c => c.Id == productQuery.ProductId)
                        .Select(c => new CartProductServiceModel()
                        {
                            ProductId = productQuery.ProductId,
                            Brand = c.Brand,
                            Description = c.Description,
                            ImageUrl = c.Images.First().Url,
                            Name = c.Name,
                            Price = c.Price,
                            Quantity = productQuery.Quantity,
                            TotalPrice = c.Price * productQuery.Quantity
                        })
                        .FirstAsync(),

                    ProductType.Accessory => await this.repository
                        .AllReadonly<Accessory>()
                        .Where(a => a.Id == productQuery.ProductId)
                        .Select(a => new CartProductServiceModel()
                        {
                            ProductId = productQuery.ProductId,
                            Brand = a.Brand,
                            Description = a.Description,
                            ImageUrl = a.Images.First().Url,
                            Name = a.Name,
                            Price = a.Price,
                            Quantity = productQuery.Quantity,
                            TotalPrice = a.Price * productQuery.Quantity
                        })
                        .FirstAsync(),

                    ProductType.Cosmetics => await this.repository
                        .AllReadonly<Cosmetic>()
                            .Where(co => co.Id == productQuery.ProductId)
                            .Select(co => new CartProductServiceModel()
                            {
                                ProductId = productQuery.ProductId,
                                Brand = co.Brand,
                                Description = co.Description,
                                ImageUrl = co.Images.First().Url,
                                Name = co.Name,
                                Price = co.Price,
                                Quantity = productQuery.Quantity,
                                TotalPrice = co.Price * productQuery.Quantity
                            })
                            .FirstAsync(),
                    _ => throw new NotImplementedException(),
                };

                productsInCart.Add(product);
            }

            return productsInCart;
        }

        public async Task<int> GetUserProductsInCartCount(string userId)
        {
            return await this.repository.AllReadonly<UserCart>(uc => uc.UserId == userId)
                .CountAsync();
        }

        public async Task<bool> UserHasProductsInCart(string userId)
        {
            return await this.repository.AllReadonly<UserCart>().AnyAsync(uc => uc.UserId == userId);
        }
    }
}
