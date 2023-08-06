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
        Task<ShopQueryServiceModel> GetAllWomensClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<ShopQueryServiceModel> GetAllMensClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<ShopQueryServiceModel> GetAllKidsClothes(
            string? category = null,
            string[]? sizes = null,
            string[]? colors = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<ShopQueryServiceModel> GetAllAccesories(
            string? category = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<ShopQueryServiceModel> GetAllCosmetics(
            string? category = null,
            int minPrice = 0,
            int maxPrice = 500,
            int currentPage = 1,
            int productsPerPage = 9);

        Task<HomeIndexServiceModel> GetCountInformation();

        Task<IEnumerable<string>> GetAllColors();

        Task<IEnumerable<string>> GetAllSizes();
    }
}
