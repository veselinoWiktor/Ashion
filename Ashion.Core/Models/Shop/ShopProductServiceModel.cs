using Ashion.Core.Models.ProductsShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Models.Shop
{
    public class ShopProductServiceModel : IProductModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;

        public string Brand { get; init; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; init; } = null!;

        public decimal Price { get; init; }
    }
}
