using Ashion.Infrastructure.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<ClothColor> ClothsColors { get; set; }
            = new List<ClothColor>();

        public IEnumerable<ClothSize> ClothsSizes { get; set; }
            = new List<ClothSize>();


    }
}
