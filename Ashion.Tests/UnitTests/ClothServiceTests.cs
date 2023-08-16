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
    public class ClothServiceTests : UnitTestsBase
    {
        private IClothService clothes;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.clothes = new ClothService(this.repo, this.mapper);
        }

        [Test]
        public async Task AllCategories_ShouldReturnCorrectCategories()
        {
            //Arrange

            //Act: invoke the service method
            var result = await this.clothes.AllCategories();

            //Assert the returned categories' count is correct
            var dbCategories = await this.repo.AllReadonly<Category>()
                .Where(c => c.ProductType == ProductType.Cloth).ToListAsync();
            Assert.That(result.Count(), Is.EqualTo(dbCategories.Count));

            //Assert the returned categories are correct
            var categoryNames = dbCategories.Select(c => c.Name);
            Assert.That(categoryNames, Does.Contain(result.FirstOrDefault()?.Name));
        }

        [Test]
        public async Task AllColors_ShouldReturnCorrectColors()
        {
            //Arrange

            //Act: invoke the service method
            var result = await this.clothes.AllColors();

            //Assert the returned colors' count is correct
            var dbColors = await this.repo.AllReadonly<Color>()
                .ToListAsync();
            Assert.That(result.Count(), Is.EqualTo(dbColors.Count));

            //Assert the returned colors are correct
            var colorNames = dbColors.Select(c => c.Name);
            Assert.That(colorNames, Does.Contain(result.FirstOrDefault()?.Name));
        }

        [Test]
        public async Task AllSizes_ShouldReturnCorrectSizes()
        {
            //Arrange

            //Act: invoke the service method
            var result = await this.clothes.AllSizes();

            //Assert the returned sizes' count is correct
            var dbSizes = await this.repo.AllReadonly<Size>()
                .ToListAsync();
            Assert.That(result.Count(), Is.EqualTo(dbSizes.Count));

            //Assert the returned sizes are correct
            var sizeSizeNumbers = dbSizes.Select(c => c.SizeNumber);
            Assert.That(sizeSizeNumbers, Does.Contain(result.FirstOrDefault()?.SizeNumber));
        }

        [Test]
        public async Task CategoryExists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get a valid category id
            var categoryId = (await this.repo.AllReadonly<Category>().FirstAsync()).Id;


            //Act: invoke the service method with valid id
            var result = await this.clothes.CategoryExists(categoryId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task ColorExists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get a valid color id
            var colorId = (await this.repo.AllReadonly<Color>().FirstAsync()).Id;


            //Act: invoke the service method with valid id
            var result = await this.clothes.ColorExists(colorId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task AllSizesExists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get a valid size ids
            var sizeIds = await this.repo.AllReadonly<Size>().Select(s => s.Id).ToListAsync();


            //Act: invoke the service method with valid id
            var result = await this.clothes.AllSizesExists(sizeIds);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Create_ShouldCreateCloth()
        {
            //Arrange: get the clothes current cound
            var clothesInDbBefore = await this.repo.AllReadonly<Cloth>().CountAsync();

            //Act: invoke the serice method with neccessary valid data
            var newClothId = await this.clothes.Create(MenCloth.Name, MenCloth.Brand,
                MenCloth.Price, MenCloth.PackageId, MenCloth.ShortContent, MenCloth.Description,
                MenCloth.Quantity, MenCloth.Category.Id, MenCloth.Color.Id, MenCloth.Gender, MenCloth.ForKids,
                MenCloth.Images.Select(i => i.Url).ToList(), MenCloth.Sizes.Select(s => s.SizeId).ToList());

            //Assert the current count increased by 1
            var clothesInDbAfter = await this.repo.AllReadonly<Cloth>().CountAsync();
            Assert.That(clothesInDbAfter, Is.EqualTo(clothesInDbBefore + 1));

            //Assert the new cloth is created with correct data
            var newClothInDb = await this.repo.GetByIdAsync<Cloth>(newClothId);
            Assert.That(newClothInDb.Name, Is.EqualTo(MenCloth.Name));
            Assert.That(newClothInDb.Brand, Is.EqualTo(MenCloth.Brand));
            Assert.That(newClothInDb.Price, Is.EqualTo(MenCloth.Price));
            Assert.That(newClothInDb.PackageId, Is.EqualTo(MenCloth.PackageId));

        }

        [Test]
        public async Task Exists_ShouldReturnTrue_WithValidId()
        {
            //Arrange: get valid rented house id
            var clothId = this.MenCloth.Id;

            //Act: invoke the service method with valid ids
            var result = await this.clothes.Exists(clothId);

            //Assert the returned result is true
            Assert.IsTrue(result);
        }

        [Test]
        public async Task Edit_ShouldEditClothCorrectly()
        {
            //Arrange: add a new cloth to the database
            var cloth = new Cloth()
            {
                Name = "Cloth Name Test",
                Brand = "Cloth Brand Test",
                Price = 200,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "Shirts", ProductType = ProductType.Cloth },
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
                Color = new Color()
                {
                    Name = "Yellow",
                },
                ForKids = false,
                Gender = Gender.Male,
                PackageId = "6BC5D723-8110-4B2B-9417-7317724292A1",
                Sizes = new List<ClothSize>()
                {
                    new ClothSize()
                    {
                        Size = new Size()
                        {
                            SizeNumber = "M"
                        }
                    }
                },
            };

            await this.repo.AddAsync(cloth);
            await this.repo.SaveChangesAsync();

            //Arrange create a variable with a changed name
            var changedName = "Cosmetic Name Test";

            //Act: invoke the serice method with valid and changed name
            await this.clothes.Edit(cloth.Id, changedName, cloth.Brand,
                cloth.Price, cloth.PackageId, cloth.ShortContent, cloth.Description, 
                cloth.Quantity, cloth.Category.Id, cloth.ColorId, cloth.Gender, cloth.ForKids,
                cloth.Images.Select(i => i.Url).ToList(), cloth.Sizes.Select(s => s.Size.Id).ToList());

            //Assert the cloth data in the database is correct
            var newClothInDb = await this.repo.GetByIdAsync<Cloth>(cloth.Id);
            Assert.That(newClothInDb, Is.Not.Null);
            Assert.That(newClothInDb.Brand, Is.EqualTo(cloth.Brand));
            Assert.That(newClothInDb.Name, Is.EqualTo(changedName));
        }

        [Test]
        public async Task Delete_ShouldDeleteClothSuccessfully()
        {
            //Arrange: add a new cloth to the database
            var cloth = new Cloth()
            {
                Name = "Cloth Name Test",
                Brand = "Cloth Brand Test",
                Price = 200,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "Shirts", ProductType = ProductType.Cloth },
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
                Color = new Color()
                {
                    Name = "Yellow",
                },
                ForKids = false,
                Gender = Gender.Male,
                PackageId = "6BC5D723-8110-4B2B-9417-7317724292A1",
                Sizes = new List<ClothSize>()
                {
                    new ClothSize()
                    {
                        Size = new Size()
                        {
                            SizeNumber = "M"
                        }
                    }
                },
            };

            await this.repo.AddAsync(cloth);
            await this.repo.SaveChangesAsync();

            //Arrange get current clothes' count
            var clothCountBefore = await this.repo.AllReadonly<Cloth>().CountAsync();

            //Act
            await this.clothes.Delete(cloth.Id);

            //Assert the returned clothes' count is decreased by 1
            var clothesCountAfter = await this.repo.AllReadonly<Cloth>().CountAsync();
            Assert.That(clothesCountAfter, Is.EqualTo(clothCountBefore - 1));

            //Assert the cloth data is not present in the db
            var clothInDb = await this.repo.GetByIdAsync<Cloth>(cloth.Id);
            Assert.That(clothInDb, Is.Null);
        }
    }
}
