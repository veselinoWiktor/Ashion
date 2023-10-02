using Ashion.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Entities
{
    public class UserCart
    {
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public User User { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [Required]
        public ProductType ProductType { get; set; }

        [Required]
        public int Quantity { get; set; }
            = 1;

        //[Required]
        //public bool IsActive { get; set; }
        //    = true;
    }
}
