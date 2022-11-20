using Ashion.Infrastructure.Data.Models.Enums;

namespace Ashion.Infrastructure.Data.Models
{
    public class ClothSize
    {
        public int ClothId { get; set; }

        public Cloth Cloth { get; set; }

        public Size Size { get; set; }
    }
}
