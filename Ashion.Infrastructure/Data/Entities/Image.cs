using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Image;

namespace Ashion.Infrastructure.Data.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxUrlLength)]
        public string Url { get; set; } = null!;

        public int? AccessoryId { get; set; }

        public Accessory? Accessory { get; set; }

        public int? ClothId { get; set; }

        public Cloth? Cloth { get; set; }

        public int? CosmeticId { get; set; }

        public Cosmetic? Cosmetic { get; set; }
    }
}
