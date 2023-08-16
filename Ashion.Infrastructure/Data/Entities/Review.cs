using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Review;


namespace Ashion.Infrastructure.Data.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(MaxContentLength)]
        public string Content { get; set; } = null!;


        [DisplayFormat(DataFormatString = "MM/dd/yyyy HH:mm:ss")]
        public DateTime CreationDate { get; set; }


        [Required]
        public string FromUserId { get; set; } = null!;

        [Required]
        public User FromUser { get; set; } = null!;

        public int? AccessoryId { get; set; }

        public Accessory? Accessory { get; set; }

        public int? ClothId { get; set; }

        public Cloth? Cloth { get; set; }

        public int? CosmeticId { get; set; }

        public Cosmetic? Cosmetic { get; set; }
    }
}
