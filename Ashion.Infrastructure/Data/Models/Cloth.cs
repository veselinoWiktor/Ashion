using Ashion.Infrastructure.Data.Models.Enums;

namespace Ashion.Infrastructure.Data.Models
{
    public class Cloth
    {
        //Essentials
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; }

        public bool InStock
            => Quantity > 0;

        //Details
        public Gender Gender { get; set; }

        public Age Age { get; set; }

        public Color Colors { get; set; }

        public Size Size { get; set; }

        public int TypeId { get; set; }

        public Type Type { get; set; }

        //ForeignKeys
        public IEnumerable<Review> Reviews { get; set; }
            = new List<Review>();
    }
}
