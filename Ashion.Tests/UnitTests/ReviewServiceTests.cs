using Ashion.Core.Contracts;
using Ashion.Core.Models.Review;
using Ashion.Core.Services;
using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Tests.UnitTests
{
    [TestFixture]
    public class ReviewServiceTests : UnitTestsBase
    {
        private IReviewService reviews;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.reviews = new ReviewService(this.repo);
        }

        [Test]
        public async Task CreateAccessoryReview_ShouldCreateAccessoryReview()
        {
            //Arrange
            var reviewsInDbBefore = await this.repo.AllReadonly<Review>()
                .Where(r => r.AccessoryId != null).CountAsync();

            //Arrange
            var newReview = new Review()
            {
                Title = "Test Title 2",
                Content = "In a Galaxy far far away...",
            };

            //Act: invoke the serice method with neccessary valid data
            var result = await this.reviews.CreateAccessoryReview(this.Accessory.Id,
                newReview.Title, newReview.Content, this.User.Id);

            //Assert the current count increased by 1
            var reviewsInDbAfter = await this.repo.AllReadonly<Review>().Where(r => r.AccessoryId != null).CountAsync();
            Assert.That(reviewsInDbAfter, Is.EqualTo(reviewsInDbBefore + 1));
        }

        [Test]
        public async Task CreateClothReview_ShouldCreateClothReview()
        {
            //Arrange
            var reviewsInDbBefore = await this.repo.AllReadonly<Review>()
                .Where(r => r.ClothId != null).CountAsync();

            //Arrange
            var newReview = new Review()
            {
                Title = "Test Title 2",
                Content = "In a Galaxy far far away...",
            };

            //Act: invoke the serice method with neccessary valid data
            var result = await this.reviews.CreateClothReview(this.MenCloth.Id,
                newReview.Title, newReview.Content, this.User.Id);

            //Assert the current count increased by 1
            var reviewsInDbAfter = await this.repo.AllReadonly<Review>().Where(r => r.ClothId != null).CountAsync();
            Assert.That(reviewsInDbAfter, Is.EqualTo(reviewsInDbBefore + 1));
        }

        [Test]
        public async Task CreateCosmeticReview_ShouldCreateCosmeticReview()
        {
            //Arrange
            var reviewsInDbBefore = await this.repo.AllReadonly<Review>()
                .Where(r => r.CosmeticId != null).CountAsync();

            //Arrange
            var newReview = new Review()
            {
                Title = "Test Title 2",
                Content = "In a Galaxy far far away...",
            };

            //Act: invoke the serice method with neccessary valid data
            var result = await this.reviews.CreateCosmeticReview(this.Cosmetic.Id,
                newReview.Title, newReview.Content, this.User.Id);

            //Assert the current count increased by 1
            var reviewsInDbAfter = await this.repo.AllReadonly<Review>().Where(r => r.CosmeticId != null).CountAsync();
            Assert.That(reviewsInDbAfter, Is.EqualTo(reviewsInDbBefore + 1));
        }

        [Test]
        public async Task GetAccessoryReviews_ShouldReturnCorrectAccessoryReviews()
        {
            //Arrange

            //Act: invoke the serice method
            var result = await this.reviews.GetAccessoryReviews(this.Accessory.Id);

            //Assert the returned count is correct
            var accessoriesReviewsInDb = await this.repo.AllReadonly<Review>()
                .Where(r => r.AccessoryId == this.Accessory.Id)
                .Select(r => new ReviewServiceModel()
                {
                    Title = r.Title,
                    Content = r.Content,
                    CreationDate = r.CreationDate.ToString("MMMM dd"),
                    FromUser = r.FromUser.FirstName + " " + r.FromUser.LastName
                })
                .ToListAsync();

            Assert.That(result.Count(), Is.EqualTo(accessoriesReviewsInDb.Count()));


            //Assert the returned data is correct
            var firstAccessoryReviewInDb = accessoriesReviewsInDb.FirstOrDefault();

            var firstResultAccessoryReview = result.FirstOrDefault();
            Assert.That(firstResultAccessoryReview?.Title, Is.EqualTo(firstAccessoryReviewInDb?.Title));
            Assert.That(firstResultAccessoryReview?.Content, Is.EqualTo(firstAccessoryReviewInDb?.Content));
        }

        [Test]
        public async Task GetClothReviews_ShouldReturnCorrectClothReviews()
        {
            //Arrange

            //Act: invoke the serice method
            var result = await this.reviews.GetClothReviews(this.MenCloth.Id);

            //Assert the returned count is correct
            var clothesReviewsInDb = await this.repo.AllReadonly<Review>()
                .Where(r => r.ClothId == this.MenCloth.Id)
                .Select(r => new ReviewServiceModel()
                {
                    Title = r.Title,
                    Content = r.Content,
                    CreationDate = r.CreationDate.ToString("MMMM dd"),
                    FromUser = r.FromUser.FirstName + " " + r.FromUser.LastName
                })
                .ToListAsync();

            Assert.That(result.Count(), Is.EqualTo(clothesReviewsInDb.Count()));


            //Assert the returned data is correct
            var firstClothReviewInDb = clothesReviewsInDb.FirstOrDefault();

            var firstResultClothReview = result.FirstOrDefault();
            Assert.That(firstResultClothReview?.Title, Is.EqualTo(firstClothReviewInDb?.Title));
            Assert.That(firstResultClothReview?.Content, Is.EqualTo(firstClothReviewInDb?.Content));
        }

        [Test]
        public async Task GetCosmeticReviews_ShouldReturnCorrectCosmeticReviews()
        {
            //Arrange

            //Act: invoke the serice method
            var result = await this.reviews.GetCosmeticReviews(this.Cosmetic.Id);

            //Assert the returned count is correct
            var cosmeticsReviewsInDb = await this.repo.AllReadonly<Review>()
                .Where(r => r.CosmeticId == this.Cosmetic.Id)
                .Select(r => new ReviewServiceModel()
                {
                    Title = r.Title,
                    Content = r.Content,
                    CreationDate = r.CreationDate.ToString("MMMM dd"),
                    FromUser = r.FromUser.FirstName + " " + r.FromUser.LastName
                })
                .ToListAsync();

            Assert.That(result.Count(), Is.EqualTo(cosmeticsReviewsInDb.Count()));


            //Assert the returned data is correct
            var firstCosmeticReviewInDb = cosmeticsReviewsInDb.FirstOrDefault();

            var firstResultCosmeticReview = result.FirstOrDefault();
            Assert.That(firstResultCosmeticReview?.Title, Is.EqualTo(firstCosmeticReviewInDb?.Title));
            Assert.That(firstResultCosmeticReview?.Content, Is.EqualTo(firstCosmeticReviewInDb?.Content));
        }
    }
}
