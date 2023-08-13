using Ashion.Core.Models.Shop;
using System.ComponentModel.DataAnnotations;

namespace Ashion.Core.Models.Clothes
{
    public class ClothDetailsServiceModel : ShopProductServiceModel
    {
        [Required]
        public string FashionType { get; set; } = null!;

        public string? ShortContent { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public bool InStock { get; set; }

        [Required]
        public IEnumerable<string> ImageUrls { get; set; } = null!;

        [Required]
        public ClothColorServiceModel MainColor { get; set; } = null!;

        [Required]
        public IEnumerable<ClothColorDetailsServiceModel> OtherColors { get; set; } = null!;

        [Required]
        public IEnumerable<ClothSizeServiceModel> Sizes { get; set; } = null!;


    }
}
