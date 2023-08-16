using Ashion.Core.Models.Review;
using Ashion.Core.Models.Shop;
using System.ComponentModel.DataAnnotations;

namespace Ashion.Core.Models.Clothes
{
    public class ClothDetailsServiceModel : ShopProductServiceModel
    {
        public string? ShortContent { get; set; }

        public bool InStock { get; set; }

        public string FashionType { get; set; } = null!;

        public string MainColor { get; set; } = null!;

        public IEnumerable<string> ImageUrls { get; set; }
            = new List<string>();

        public IEnumerable<string> Sizes { get; set; }
            = new List<string>();

        public IEnumerable<ClothColorDetailsServiceModel> OtherColors { get; set; }
            = new List<ClothColorDetailsServiceModel>();

        public IEnumerable<ReviewServiceModel> Reviews { get; set; }
            = new List<ReviewServiceModel>();

    }
}
