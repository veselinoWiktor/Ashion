using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Models.ProductsShared
{
    public interface IProductModel
    {
        public string Name { get; }

        public string Brand { get; }

        public string Description { get; }
    }
}
