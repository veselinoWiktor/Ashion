using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.User;

namespace Ashion.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; set; } = null!;

        public string? ImageUrl { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
            = new List<Review>();
    }
}
