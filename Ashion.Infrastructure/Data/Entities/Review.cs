using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ashion.Infrastructure.Data.DataConstants.Review;


namespace Ashion.Infrastructure.Data.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(MaxContentLength)]
        public string Content { get; set; } = null!;

        [Required]
        public string FromUserId { get; set; } = null!;

        [Required]
        public User FromUser { get; set; } = null!;
    }
}
