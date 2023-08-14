using Ashion.Core.Models.Clothes;
using Ashion.Core.Models.ProductsShared;
using Ashion.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using static Ashion.Infrastructure.Data.DataConstants.Product;

namespace Ashion.Web.Areas.Admin.Models.Clothes
{
    public class ClothFormModel : IProductModel
    {
        [Required]
        [Display(Name = "Package Identifier")]
        public string PackageId { get; set; } = null!;

        [Required]
        [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(MaxBrandLength, MinimumLength = MinBrandLength)]
        public string Brand { get; set; } = null!;

        [Required]
        [Range(MinPriceRange, MaxPriceRange,
            ErrorMessage = "Price must be a positive number and less that {2} leva")]
        public decimal Price { get; set; }

        [StringLength(MaxShortContentLength)]
        public string? ShortContent { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength, MinimumLength = MinDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(MinQuantityRange, MaxQuantityRange)]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Color")]
        public int ColorId { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "For Kids")]
        public bool ForKids { get; set; }

        [Required]
        [Display(Name = "Images")]
        public IEnumerable<string> ImageUrls { get; set; }
            = new List<string>();

        [Required]
        [Display(Name = "Sizes")]
        public IEnumerable<int> SizesIds { get; set; }
            = new List<int>();

        public IEnumerable<ProductCategoryServiceModel> Categories { get; set; }
            = new List<ProductCategoryServiceModel>();

        public IEnumerable<ClothColorServiceModel> Colors { get; set; }
            = new List<ClothColorServiceModel>();

        public IEnumerable<ClothSizeServiceModel> Sizes { get; set; }
            = new List<ClothSizeServiceModel>();
    }
}
