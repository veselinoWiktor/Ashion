namespace Ashion.Core.Models.Shop
{
    public class ShopQueryServiceModel
    {
        public int TotalProductsCount { get; set; }

        public IEnumerable<ShopProductServiceModel> Products { get; set; }
            = new List<ShopProductServiceModel>();
    }
}
