using Ashion.Core.Models.Shop;
using System.ComponentModel.DataAnnotations;

namespace Ashion.Core.Models.Accessory
{
    public class AccessoryDetailsServiceModel : ShopProductServiceModel
    {
        public string? ShortContent { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool InStock { get; set; }

        [Required]
        public IEnumerable<string> ImageUrls { get; set; } = null!;
    }
}
