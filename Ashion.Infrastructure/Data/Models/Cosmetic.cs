using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Cosmetic;

namespace Ashion.Infrastructure.Data.Models
{
    public class Cosmetic
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

        [MaxLength(MaxDescriptionLength)]
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
        [MaxLength(MaxIntededLength)]
        public string Inteded { get; set; } = null!;

        //ForeignKeys        
        public IEnumerable<Review> Reviews { get; set; }
            = new List<Review>();
    }
}
