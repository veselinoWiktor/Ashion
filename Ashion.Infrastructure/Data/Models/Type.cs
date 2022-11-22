using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Type;

namespace Ashion.Infrastructure.Data.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTypeNameLength)]
        public string TypeName { get; set; } = null!;

        public IEnumerable<Cloth> Cloths { get; set; }
            = new List<Cloth>();
    }
}
