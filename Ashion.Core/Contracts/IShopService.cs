using Ashion.Core.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Contracts
{
    public interface IShopService
    {
        Task<IEnumerable<ShopProductServiceModel>> GetAllProducts(
            string? category = null,
            string? size = null,
            string? color = null,
            int minPrice = 0,
            int maxPrice = 300,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<IEnumerable<ShopProductServiceModel>> GetAllWomensClothes();

        Task<IEnumerable<ShopProductServiceModel>> GetAllMensClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<IEnumerable<ShopProductServiceModel>> GetAllKidsClothes();

        Task<IEnumerable<ShopProductServiceModel>> GetAllAccesories();

        Task<IEnumerable<ShopProductServiceModel>> GetAllCosmetics();

        Task<HomeIndexServiceModel> GetCountInformation();

        Task<IEnumerable<string>> GetAllColors();

        Task<IEnumerable<string>> GetAllSizes();
    }
}
