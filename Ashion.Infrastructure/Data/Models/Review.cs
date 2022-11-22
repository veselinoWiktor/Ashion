using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Review;


namespace Ashion.Infrastructure.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public User User { get; set; } = null!;

        public int? ClothId { get; set; }

        public Cloth? Cloth { get; set; }

        public int? AccessoryId { get; set; }

        public Accessory? Accessory { get; set; }

        public int? CosmeticId { get; set; }

        public Cosmetic? Cosmetic { get; set; }

        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; } = null!;

        [Required]
        public decimal Rating { get; set; }
    }
}
