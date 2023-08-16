using Ashion.Core.Contracts;
using Ashion.Core.Models.ProductsShared;
using Ashion.Core.Models.Review;
using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Core.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository repository;

        public ReviewService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<string> CreateAccessoryReview(int accessoryId, string title, string content, string userId)
        {
            var accessory = await this.repository.GetByIdAsync<Accessory>(accessoryId);

            var review = new Review()
            {
                Title = title,
                Content = content,
                CreationDate = DateTime.UtcNow,
                FromUserId = userId,
            };

            var reviews = accessory.Reviews.ToList();
            reviews.Add(review);

            accessory.Reviews = reviews;

            await this.repository.SaveChangesAsync();

            return GetInformation(accessory.Name, accessory.Brand, accessory.Description);
        }

        public async Task<string> CreateClothReview(int clothId, string title, string content, string userId)
        {
            var cloth = await this.repository.GetByIdAsync<Cloth>(clothId);

            var review = new Review()
            {
                Title = title,
                Content = content,
                CreationDate = DateTime.UtcNow,
                FromUserId = userId,
            };

            var reviews = cloth.Reviews.ToList();
            reviews.Add(review);

            cloth.Reviews = reviews;

            await this.repository.SaveChangesAsync();

            return GetInformation(cloth.Name, cloth.Brand, cloth.Description);
        }

        public async Task<string> CreateCosmeticReview(int cosmeticId, string title, string content, string userId)
        {
            var cosmetic = await this.repository.GetByIdAsync<Cosmetic>(cosmeticId);

            var review = new Review()
            {
                Title = title,
                Content = content,
                CreationDate = DateTime.UtcNow,
                FromUserId = userId,
            };

            var reviews = cosmetic.Reviews.ToList();
            reviews.Add(review);

            cosmetic.Reviews = reviews;

            await this.repository.SaveChangesAsync();

            return GetInformation(cosmetic.Name, cosmetic.Brand, cosmetic.Description);
        }

        public async Task<IEnumerable<ReviewServiceModel>> GetAccessoryReviews(int accessoryId)
        {
            return await this.repository.AllReadonly<Review>()
                .Where(r => r.AccessoryId == accessoryId)
                .Select(r => new ReviewServiceModel()
                {
                    Title = r.Title,
                    Content = r.Content,
                    CreationDate = r.CreationDate.ToString("MMMM dd"),
                    FromUser = r.FromUser.FirstName + " " + r.FromUser.LastName
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ReviewServiceModel>> GetClothReviews(int clothId)
        {
            return await this.repository.AllReadonly<Review>()
                .Where(r => r.ClothId == clothId)
                .Select(r => new ReviewServiceModel()
                {
                    Title = r.Title,
                    Content = r.Content,
                    CreationDate = r.CreationDate.ToString("MMMM dd"),
                    FromUser = r.FromUser.FirstName + " " + r.FromUser.LastName
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ReviewServiceModel>> GetCosmeticReviews(int comseticId)
        {
            return await this.repository.AllReadonly<Review>()
                .Where(r => r.CosmeticId == comseticId)
                .Select(r => new ReviewServiceModel()
                {
                    Title = r.Title,
                    Content = r.Content,
                    CreationDate = r.CreationDate.ToString("MMMM dd"),
                    FromUser = r.FromUser.FirstName + " " + r.FromUser.LastName
                })
                .ToListAsync();
        }

        private static string GetInformation(string name, string brand, string description)
        {
            return name.Replace(" ", "-") + "-" + brand + "-" + description.Count();
        }
    }
}
