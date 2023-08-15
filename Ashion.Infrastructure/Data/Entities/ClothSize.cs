namespace Ashion.Infrastructure.Data.Entities
{
    public class ClothSize
    {
        public int ClothId { get; set; }

        public Cloth Cloth { get; set; } = null!;

        public int SizeId { get; set; }

        public Size Size { get; set; } = null!;
    }
}
