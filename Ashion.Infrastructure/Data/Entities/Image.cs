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
    }
}
