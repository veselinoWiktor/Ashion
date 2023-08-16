using System.ComponentModel.DataAnnotations;
using static Ashion.Infrastructure.Data.DataConstants.Review;

namespace Ashion.Web.Models.Review
{
    public class ReviewFormModel
    {
        [Required]
        [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(MaxContentLength, MinimumLength = MinContentLength)]
        public string Content { get; set; } = null!;
    }
}
