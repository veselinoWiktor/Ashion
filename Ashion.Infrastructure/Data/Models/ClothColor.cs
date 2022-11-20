using Ashion.Infrastructure.Data.Models.Enums;

namespace Ashion.Infrastructure.Data.Models
{
    public class ClothColor
    {
        public int ClothId { get; set; }

        public Cloth Cloth { get; set; }

        public Color Color { get; set; }
    }
}
