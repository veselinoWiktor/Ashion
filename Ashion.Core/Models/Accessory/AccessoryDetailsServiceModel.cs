using Ashion.Core.Models.ProductsShared;
using Ashion.Core.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
