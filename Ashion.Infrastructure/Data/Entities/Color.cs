using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Color;

namespace Ashion.Infrastructure.Data.Entities
{
    public class Color
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; } = null!;

        public IEnumerable<Cloth> Cloths { get; set; }
            = new List<Cloth>();
    }
}
