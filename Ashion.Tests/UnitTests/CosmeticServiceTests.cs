using Ashion.Core.Contracts;
using Ashion.Core.Services;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Tests.UnitTests
{
    public class CosmeticServiceTests : UnitTestsBase
    {
        private ICosmeticsService cosmetics;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.cosmetics = new CosmeticsService(this.repo, this.mapper);
        }

        [Test]
        public async Task AllCategories_ShouldReturnCorrectCategories()
        {
            //Arrange

            //Act: invoke the service method
            var result = await this.cosmetics.AllCategories();

            //Assert the returned categories' count is correct
            var dbCategories = await this.repo.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Cosmetics).ToListAsync();
            Assert.That(result.Count(), Is.EqualTo(dbCategories.Count));

            //Assert the returned categories are correct
            var categoryNames = dbCategories.Select(c => c.Name);
            Assert.That(categoryNames, Does.Contain(result.FirstOrDefault()?.Name));
        }

        [Test]
        public async Task CategoryExists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get a valid category id
            var categoryId = (await this.repo.AllReadonly<Category>().FirstAsync()).Id;


            //Act: invoke the service method with valid id
            var result = await this.cosmetics.CategoryExists(categoryId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Create_ShouldCreateCosmetic()
        {
            //Arrange: get the cosmetics current cound
            var cosmeticsInDbBefore = await this.repo.AllReadonly<Cosmetic>().CountAsync();

            //Arrange: create a new cosmetic variable with needed data
            var newCosmetic = new Cosmetic()
            {
                Name = "Cosmetic Name",
                Brand = "Cosmetic Brand",
                Price = 60,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "Face", ProductType = ProductType.Cosmetics },
                Quantity = 5,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        Url = "firstCosmeticImageUrl"
                    },
                    new Image()
                    {
                        Url = "secondCosmeticImageUrl"
                    }
                },
                Ingredients = "Cosmetic Ingredients Test"
            };

            //Act: invoke the serice method with neccessary valid data
            var newCosmeticId = await this.cosmetics.Create(newCosmetic.Name, newCosmetic.Brand,
                newCosmetic.Price, newCosmetic.ShortContent, newCosmetic.Description, newCosmetic.Ingredients,
                newCosmetic.Quantity, newCosmetic.Category.Id, newCosmetic.Images.Select(i => i.Url).ToList());

            //Assert the current count increased by 1
            var cosmeticsInDbAfter = await this.repo.AllReadonly<Cosmetic>().CountAsync();
            Assert.That(cosmeticsInDbAfter, Is.EqualTo(cosmeticsInDbBefore + 1));

            //Assert the new cloth is created with correct data
            var newCosmeticInDb = await this.repo.GetByIdAsync<Cosmetic>(newCosmeticId);
            Assert.That(newCosmeticInDb.Name, Is.EqualTo(newCosmetic.Name));
            Assert.That(newCosmeticInDb.Brand, Is.EqualTo(newCosmetic.Brand));
            Assert.That(newCosmeticInDb.Price, Is.EqualTo(newCosmetic.Price));
            Assert.That(newCosmeticInDb.Ingredients, Is.EqualTo(newCosmetic.Ingredients));
        }

        [Test]
        public async Task Exists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get valid cosmetic id
            var comseticId = this.Cosmetic.Id;

            //Act: invoke the service method with valid ids
            var result = await this.cosmetics.Exists(comseticId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task CosmeticDetailsById_ShouldReturnCorrectCosmeticData()
        {
            //Arrange: get a valid cosmetic id
            var cosmeticId = this.Cosmetic.Id;

            //Act: invoke the service method with the valid id
            var result = await this.cosmetics.CosmeticDetailsById(cosmeticId);

            //Assert the returned result is not null
            Assert.That(result, Is.Not.Null);

            //Assert the returned result data is correct
            var cosmeticInDb = await this.repo.GetByIdAsync<Cosmetic>(cosmeticId);
            Assert.That(result.Id, Is.EqualTo(cosmeticInDb.Id));
            Assert.That(result.Name, Is.EqualTo(cosmeticInDb.Name));
            Assert.That(result.Brand, Is.EqualTo(cosmeticInDb.Brand));
            Assert.That(result.Ingredients, Is.EqualTo(cosmeticInDb.Ingredients));
        }

        [Test]
        public async Task GetCosmeticCategoryId_ShouldReturnCorrectId()
        {
            //Arrange: get valid cosmetic id
            var cosmeticId = this.Cosmetic.Id;

            //Act: invoke the service method with valid id
            var result = await this.cosmetics.GetCosmeticCategoryId(cosmeticId);

            //Assert the returned result is not null    
            Assert.IsNotNull(result);

            //Assert the returned category is correct
            var categoryId = this.Cosmetic.Category.Id;
            Assert.That(result, Is.EqualTo(categoryId));
        }

        [Test]
        public async Task Edit_ShouldEditCosmeticCorrectly()
        {
            //Arrange: add a new cosmetic to the database
            var cosmetic = new Cosmetic()
            {
                Name = "Cosmetic Name",
                Brand = "Cosmetic Brand",
                Price = 60,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "Face", ProductType = ProductType.Cosmetics },
                Quantity = 5,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        Url = "firstCosmeticImageUrl"
                    },
                    new Image()
                    {
                        Url = "secondCosmeticImageUrl"
                    }
                },
                Ingredients = "Cosmetic Ingredients Test"
            };

            await this.repo.AddAsync(cosmetic);
            await this.repo.SaveChangesAsync();

            //Arrange create a variable with a changed name
            var changedName = "Cosmetic Name Test";

            //Act: invoke the serice method with valid and changed name
            await this.cosmetics.Edit(cosmetic.Id, changedName, cosmetic.Brand,
                cosmetic.Price, cosmetic.ShortContent, cosmetic.Description, cosmetic.Ingredients, cosmetic.Quantity,
                cosmetic.Category.Id, cosmetic.Images.Select(i => i.Url).ToList());

            //Assert the cosmetic data in the database is correct
            var newCosmeticInDb = await this.repo.GetByIdAsync<Cosmetic>(cosmetic.Id);
            Assert.That(newCosmeticInDb, Is.Not.Null);
            Assert.That(newCosmeticInDb.Brand, Is.EqualTo(cosmetic.Brand));
            Assert.That(newCosmeticInDb.Name, Is.EqualTo(changedName));
        }

        [Test]
        public async Task Delete_ShouldDeleteCosmeticSuccessfully()
        {
            //Arrange: add a new cosmetic to the database
            var cosmetic = new Cosmetic()
            {
                Name = "Cosmetic Name",
                Brand = "Cosmetic Brand",
                Price = 60,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "Face", ProductType = ProductType.Cosmetics },
                Quantity = 5,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        Url = "firstCosmeticImageUrl"
                    },
                    new Image()
                    {
                        Url = "secondCosmeticImageUrl"
                    }
                },
                Ingredients = "Cosmetic Ingredients Test"
            };

            await this.repo.AddAsync(cosmetic);
            await this.repo.SaveChangesAsync();

            //Arrange get current cosmetics' count
            var cosmeticsCountBefore = await this.repo.AllReadonly<Cosmetic>().CountAsync();

            //Act
            await this.cosmetics.Delete(cosmetic.Id);

            //Assert the returned cosmetics' count is decreased by 1
            var cosmeticsCountAfter = await this.repo.AllReadonly<Cosmetic>().CountAsync();
            Assert.That(cosmeticsCountAfter, Is.EqualTo(cosmeticsCountBefore - 1));

            //Assert the cosmetic data is not present in the db
            var cosmeticInDb = await this.repo.GetByIdAsync<Cosmetic>(cosmetic.Id);
            Assert.That(cosmeticInDb, Is.Null);
        }
    }
}
