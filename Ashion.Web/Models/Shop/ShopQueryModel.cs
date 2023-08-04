﻿using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Data.Entities;

namespace Ashion.Web.Models.Shop
{
    public class ShopQueryModel
    {
        public const int ProductsPerPage = 9;

        public string Category { get; set; } = null!;

        public string[] Size { get; set; } = null!;

        public string[] Color { get; set; } = null!;

        public int MinPriceRange { get; set; } = 0;

        public int MaxPriceRange { get; set; } = 300;

        public int CurrentPage { get; init; } = 1;

        public int TotalProductsCount { get; set; }

        public IEnumerable<string> Sizes { get; set; } = null!;

        public IEnumerable<string> Colors { get; set; } = null!;

        public IEnumerable<ShopProductServiceModel> Products { get; set; }
            = new List<ShopProductServiceModel>();
    }
}
