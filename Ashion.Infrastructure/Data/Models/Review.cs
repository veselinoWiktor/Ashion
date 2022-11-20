using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int? ClothId { get; set; }

        public Cloth? Cloth { get; set; }

        public int? AccessoryId { get; set; }

        public Accessory? Accessory { get; set; }

        public int? CosmeticId { get; set; }

        public Cosmetic? Cosmetic { get; set; }

        public string Description { get; set; }

        public decimal Rating { get; set; }
    }
}
