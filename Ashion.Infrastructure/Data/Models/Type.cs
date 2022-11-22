using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Models
{
    public class Type
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public IEnumerable<Cloth> Cloths { get; set; }
            = new List<Cloth>();
    }
}
