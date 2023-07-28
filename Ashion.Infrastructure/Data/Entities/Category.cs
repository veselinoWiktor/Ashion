using Ashion.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Cateogry;

namespace Ashion.Infrastructure.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; init; }
            
        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; init; } = null!;

        [Required]
        public ProductType ProductType { get; init; }
    }
}
