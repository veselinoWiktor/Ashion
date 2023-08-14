using Ashion.Core.Models.Shop;
using Ashion.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Models.Clothes
{
    public class ClothServiceModel : ShopProductServiceModel
    {
        public string PackageId { get; set; } = null!;

        public string? ShortContent { get; set; }

        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        public int ColorId { get; set; }

        public Gender Gender { get; set; }

        public bool ForKids { get; set; }

        public IEnumerable<string> ImageUrls { get; set; }
            = new List<string>();

        public IEnumerable<int> SizesIds { get; set; }
            = new List<int>();
    }
}
