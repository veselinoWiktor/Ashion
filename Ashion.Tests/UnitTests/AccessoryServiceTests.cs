using Ashion.Core.Contracts;
using Ashion.Core.Services;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ashion.Tests.UnitTests
{
    public class AccessoryServiceTests : UnitTestsBase
    {
        private IAccessoriesService accessories;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.accessories = new AccessoriesService(this.repo, this.mapper);
        }

        [Test]
        public async Task AllCategories_ShouldReturnCorrectCategories()
        {
            //Arrange

            //Act: invoke the service method
            var result = await this.accessories.AllCategories();

            //Assert the returned categories' count is correct
            var dbCategories = await this.repo.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Accessory).ToListAsync();
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
            var result = await this.accessories.CategoryExists(categoryId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Create_ShouldCreateAccessory()
        {
            //Arrange: get the accessory current cound
            var accessoriesInDbBefore = await this.repo.AllReadonly<Accessory>().CountAsync();

            //Arrange: create a new accessory variable with needed data
            var newAccessory = new Accessory()
            {
                Name = "Test Accessory",
                Brand = "Ray Ban",
                Price = 200,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "TestCategory", ProductType = ProductType.Accessory },
                Quantity = 6,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        Url = "firstImageUrl"
                    },
                    new Image()
                    {
                        Url = "secondImageUrl"
                    }
                }
            };

            //Act: invoke the serice method with neccessary valid data
            var newAccessoryId = await this.accessories.Create(newAccessory.Name, newAccessory.Brand,
                newAccessory.Price, newAccessory.ShortContent, newAccessory.Description,
                newAccessory.Quantity, newAccessory.Category.Id, newAccessory.Images.Select(i => i.Url).ToList());

            //Assert the current count increased by 1
            var accessoriesInDbAfter = await this.repo.AllReadonly<Accessory>().CountAsync();
            Assert.That(accessoriesInDbAfter, Is.EqualTo(accessoriesInDbBefore + 1));

            //Assert the new accessory is created with correct data
            var newAccessoryInDb = await this.repo.GetByIdAsync<Accessory>(newAccessoryId);
            Assert.That(newAccessoryInDb.Name, Is.EqualTo(newAccessory.Name));
            Assert.That(newAccessoryInDb.Brand, Is.EqualTo(newAccessory.Brand));
            Assert.That(newAccessoryInDb.Price, Is.EqualTo(newAccessory.Price));
        }

        [Test]
        public async Task Exists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get valid accessory id
            var accessoryId = this.Accessory.Id;

            //Act: invoke the service method with valid ids
            var result = await this.accessories.Exists(accessoryId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task AccessoryDetailsById_ShouldReturnCorrectAccessoryData()
        {
            //Arrange: get a valid accessory id
            var accessoryId = this.Accessory.Id;

            //Act: invoke the service method with the valid id
            var result = await this.accessories.AccessoryDetailsById(accessoryId);

            //Assert the returned result is not null
            Assert.That(result, Is.Not.Null);

            //Assert the returned result data is correct
            var accessoryInDb = await this.repo.GetByIdAsync<Accessory>(accessoryId);
            Assert.That(result.Id, Is.EqualTo(accessoryInDb.Id));
            Assert.That(result.Name, Is.EqualTo(accessoryInDb.Name));
            Assert.That(result.Brand, Is.EqualTo(accessoryInDb.Brand));
        }

        [Test]
        public async Task GetAccessoryCategoryId_ShouldReturnCorrectId()
        {
            //Arrange: get valid accessory
            var accessoryId = this.Accessory.Id;

            //Act: invoke the service method with valid id
            var result = await this.accessories.GetAccessoryCategoryId(accessoryId);

            //Assert the returned result is not null    
            Assert.IsNotNull(result);

            //Assert the returned category is correct
            var categoryId = this.Accessory.Category.Id;
            Assert.That(result, Is.EqualTo(categoryId));
        }

        [Test]
        public async Task Edit_ShouldEditAccessoryCorrectly()
        {
            //Arrange: add a new accessory to the database
            var accessory = new Accessory()
            {
                Name = "Test Accessory",
                Brand = "Ray Ban",
                Price = 200,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "TestCategory", ProductType = ProductType.Accessory },
                Quantity = 6,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        Url = "firstImageUrl"
                    },
                    new Image()
                    {
                        Url = "secondImageUrl"
                    }
                }
            };

            await this.repo.AddAsync(accessory);
            await this.repo.SaveChangesAsync();

            //Arrange create a variable with a changed name
            var changedName = "Accessory Test";

            //Act: invoke the serice method with valid and changed name
            await this.accessories.Edit(accessory.Id, changedName, accessory.Brand,
                accessory.Price, accessory.ShortContent, accessory.Description, accessory.Quantity,
                accessory.Category.Id, accessory.Images.Select(i => i.Url).ToList());

            //Assert the accessory data in the database is correct
            var newAccessoryInDb = await this.repo.GetByIdAsync<Accessory>(accessory.Id);
            Assert.That(newAccessoryInDb, Is.Not.Null);
            Assert.That(newAccessoryInDb.Brand, Is.EqualTo(accessory.Brand));
            Assert.That(newAccessoryInDb.Name, Is.EqualTo(changedName));
        }

        [Test]
        public async Task Delete_ShouldDeleteAccessorySuccessfully()
        {
            //Arrange: add a new accessory to the database
            var accessory = new Accessory()
            {
                Name = "Test Accessory",
                Brand = "Ray Ban",
                Price = 200,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "TestCategory", ProductType = ProductType.Accessory },
                Quantity = 6,
                Images = new List<Image>()
                {
                    new Image()
                    {
                        Url = "firstImageUrl"
                    },
                    new Image()
                    {
                        Url = "secondImageUrl"
                    }
                }
            };

            await this.repo.AddAsync(accessory);
            await this.repo.SaveChangesAsync();

            //Arrange get current accessories' count
            var accessoriesCountBefore = await this.repo.AllReadonly<Accessory>().CountAsync();

            //Act
            await this.accessories.Delete(accessory.Id);

            //Assert the returned accessories' count is decreased by 1
            var accessoriesCountAfter = await this.repo.AllReadonly<Accessory>().CountAsync();
            Assert.That(accessoriesCountAfter, Is.EqualTo(accessoriesCountBefore - 1));

            //Assert the accessory data is not present in the db
            var accessoryInDb = await this.repo.GetByIdAsync<Accessory>(accessory.Id);
            Assert.That(accessoryInDb, Is.Null);
        }

    }
}
