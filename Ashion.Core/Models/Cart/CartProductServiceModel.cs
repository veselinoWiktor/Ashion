using Ashion.Core.Models.ProductsShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Models.Cart
{
    public class CartProductServiceModel : IProductModel
    {
        public int ProductId { get; set; } 

        public string Name { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
