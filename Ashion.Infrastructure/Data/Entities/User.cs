using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.User;

namespace Ashion.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(MaxFirstNameLength)]
        public string FirstName { get; init; } = null!;

        [Required]
        [MaxLength(MaxLastNameLength)]
        public string LastName { get; init; } = null!;
    }
}
