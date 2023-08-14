using Ashion.Core.Models.ProductsShared;

namespace Ashion.Web.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IProductModel product)
        {
            return product.Name.Replace(" ", "-") + "-" + product.Brand + "-" + product.Description.Count();
        }
    }
}
