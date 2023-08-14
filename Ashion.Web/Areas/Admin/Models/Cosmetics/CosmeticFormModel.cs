﻿using Ashion.Core.Models.ProductsShared;
using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Product;
using static Ashion.Infrastructure.Data.DataConstants.Cosmetic;

namespace Ashion.Web.Areas.Admin.Models.Cosmetics
{
    public class CosmeticFormModel
    {
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
        [StringLength(MaxIngredintsLength, MinimumLength = MinIngredintsLength)]
        public string Ingredients { get; set; } = null!;

        [Required]
        [Range(MinQuantityRange, MaxQuantityRange)]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<ProductCategoryServiceModel> Categories { get; set; }
            = new List<ProductCategoryServiceModel>();

        [Required]
        [Display(Name = "Images")]
        public IEnumerable<string> ImageUrls { get; set; }
            = new List<string>();
    }
}
