using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
