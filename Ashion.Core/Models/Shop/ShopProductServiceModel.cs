using Ashion.Core.Models.ProductsShared;

namespace Ashion.Core.Models.Shop
{
    public class ShopProductServiceModel : IProductModel
    {
        public int Id { get; init; }

        public string Name { get; init; } = null!;

        public string Brand { get; init; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; init; }

        public decimal Price { get; init; }
    }
}
