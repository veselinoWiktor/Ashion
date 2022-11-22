using Ashion.Infrastructure.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Ashion.Infrastructure.Data.DataConstants.Cloth;

namespace Ashion.Infrastructure.Data.Models
{
    public class Cloth
    {
        //Essentials
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(MaxBrandLength)]
        public string Brand { get; set; } = null!;

        [MaxLength(MaxBrandLength)]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public int Quantity { get; set; }

        public bool InStock
            => Quantity > 0;

        //Details
        [Required]
        public Gender Gender { get; set; }

        [Required]
        public Age Age { get; set; }

        [Required]
        public Color Colors { get; set; }

        [Required]
        public Size Size { get; set; }

        [Required]
        public int TypeId { get; set; }

        public Type Type { get; set; } = null!;

        //ForeignKeys
        public IEnumerable<Review>? Reviews { get; set; }
            = new List<Review>();
    }
}
