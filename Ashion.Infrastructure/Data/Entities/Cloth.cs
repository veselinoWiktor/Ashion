using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Product;

namespace Ashion.Infrastructure.Data.Entities
{
    public class Cloth 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MaxBrandLength)]
        public string Brand { get; set; } = null!;

        [Required]
        [Range(MinPriceRange, MaxPriceRange)]
        [Precision(18, 2)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [MaxLength(MaxShortContentLength)]
        public string? ShortContent { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(MinQuantityRange, MaxQuantityRange)]
        public int Quantity { get; set; }

        public bool InStock
            => Quantity > 0;

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; } = null!;

        public IEnumerable<Image> Images { get; set; }
            = new List<Image>();

        public IEnumerable<Review> Reviews { get; set; }
            = new List<Review>();

        [Required]
        public IEnumerable<ClothColor> Colors { get; init; }
            = new List<ClothColor>();

        [Required]
        public IEnumerable<ClothSize> Sizes { get; init; }
            = new List<ClothSize>();

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public bool ForKids { get; set; }
    }
}
