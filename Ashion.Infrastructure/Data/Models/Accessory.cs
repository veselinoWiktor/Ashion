using Ashion.Infrastructure.Data.Models.Enums;

namespace Ashion.Infrastructure.Data.Models
{
    public class Accessory
    {
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

        //ForeignKeys
        public IEnumerable<Review> Reviews { get; set; }
            = new List<Review>();
    }
}
