using Ashion.Core.Models.Review;

namespace Ashion.Core.Contracts
{
    public interface IReviewService
    {

        Task<string> CreateAccessoryReview(int accessoryId, string title, string content, string userId);

        Task<string> CreateClothReview(int clothId, string title, string content, string userId);

        Task<string> CreateCosmeticReview(int cosmeticId, string title, string content, string userId);

        Task<IEnumerable<ReviewServiceModel>> GetAccessoryReviews(int accessoryId);

        Task<IEnumerable<ReviewServiceModel>> GetClothReviews(int clothId);

        Task<IEnumerable<ReviewServiceModel>> GetCosmeticReviews(int comseticId);

    }
}
