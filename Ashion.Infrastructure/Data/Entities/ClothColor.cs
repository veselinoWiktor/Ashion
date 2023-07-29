using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Entities
{
    public class ClothColor
    {
        public int ClothId { get; set; }

        public Cloth Cloth { get; set; } = null!;

        public int ColorId { get; set; }

        public Color Color { get; set; } = null!;
    }
}
