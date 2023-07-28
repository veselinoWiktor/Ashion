using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Size;


namespace Ashion.Infrastructure.Data.Entities
{
    public class Size
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxSizeNumberLength)]
        public string SizeNumber { get; set; } = null!;

        public IEnumerable<ClothSize> Cloths { get; set; }
            = new List<ClothSize>();
    }
}
