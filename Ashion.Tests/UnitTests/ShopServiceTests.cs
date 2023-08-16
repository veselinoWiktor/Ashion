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
    [TestFixture]
    public class ShopServiceTests : UnitTestsBase
    {
        private IShopService shop;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.shop = new ShopService(this.repo);
        }

        [Test]
        public async Task GetAllAccessories_ShouldReturnCorrectAccessories()
        {
            //Arrange: create a variable for the category
            var categoryName = "Sunglasses";

            //Act
            var result = await this.shop.GetAllAccesories(categoryName);


            //Assert
            var accessoriesInDb = await this.repo.AllReadonly<Accessory>()
                .Where(a => a.Category.Name == categoryName)
                .ToListAsync();
            Assert.That(result.TotalProductsCount, Is.EqualTo(accessoriesInDb.Count));

            //Assert the returned house data is correct
            var resultAccessory = result.Products.FirstOrDefault();
            Assert.That(resultAccessory, Is.Not.Null);

            var accessoryInDb = accessoriesInDb.FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(resultAccessory.Id, Is.EqualTo(accessoryInDb?.Id));
                Assert.That(resultAccessory.Name, Is.EqualTo(accessoryInDb?.Name));
                Assert.That(resultAccessory.Brand, Is.EqualTo(accessoryInDb?.Brand));
            });
        }

        [Test]
        public async Task GetAllCosmetics_ShouldReturnCorrectCosmetics()
        {
            //Arrange: create a variable for the category
            var categoryName = "SPF";

            //Act
            var result = await this.shop.GetAllCosmetics(categoryName);


            //Assert
            var cosmeticsInDb = await this.repo.AllReadonly<Cosmetic>()
                .Where(c => c.Category.Name == categoryName)
                .ToListAsync();
            Assert.That(result.TotalProductsCount, Is.EqualTo(cosmeticsInDb.Count));

            //Assert the returned house data is correct
            var resultCosmetic = result.Products.FirstOrDefault();
            Assert.That(resultCosmetic, Is.Not.Null);

            var cosmeticInDb = cosmeticsInDb.FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(resultCosmetic.Id, Is.EqualTo(cosmeticInDb?.Id));
                Assert.That(resultCosmetic.Name, Is.EqualTo(cosmeticInDb?.Name));
                Assert.That(resultCosmetic.Brand, Is.EqualTo(cosmeticInDb?.Brand));
            });
        }

        [Test]
        public async Task GetAllMensClothes_ShouldReturnCorrectCosmetics()
        {
            //Arrange: create a variable for the category
            var categoryName = "T-Shirts";

            //Act
            var result = await this.shop.GetAllMensClothes(categoryName);


            //Assert
            var clothsInDb = await this.repo.AllReadonly<Cloth>()
                .Where(c => c.Category.Name == categoryName && c.Gender == Gender.Male && c.ForKids == false)
                .ToListAsync();
            Assert.That(result.TotalProductsCount, Is.EqualTo(clothsInDb.Count));

            //Assert the returned house data is correct
            var resultCloth = result.Products.FirstOrDefault();
            Assert.That(resultCloth, Is.Not.Null);

            var clothInDb = clothsInDb.FirstOrDefault();
            Assert.Multiple((TestDelegate)(() =>
            {
                Assert.That(resultCloth.Id, Is.EqualTo(clothInDb?.Id));
                Assert.That<string>(resultCloth.Name, Is.EqualTo(clothInDb?.Name));
                Assert.That<string>(resultCloth.Brand, Is.EqualTo(clothInDb?.Brand));
            }));
        }

        [Test]
        public async Task GetAllWomensClothes_ShouldReturnCorrectCosmetics()
        {
            //Arrange: create a variable for the category
            var categoryName = "T-Shirts";

            //Act
            var result = await this.shop.GetAllWomensClothes(categoryName);


            //Assert
            var clothsInDb = await this.repo.AllReadonly<Cloth>()
                .Where(c => c.Category.Name == categoryName && c.Gender == Gender.Female && c.ForKids == false)
                .ToListAsync();
            Assert.That(result.TotalProductsCount, Is.EqualTo(clothsInDb.Count));

            //Assert the returned house data is correct
            var resultCloth = result.Products.FirstOrDefault();
            Assert.That(resultCloth, Is.Not.Null);

            var clothInDb = clothsInDb.FirstOrDefault();
            Assert.Multiple((TestDelegate)(() =>
            {
                Assert.That(resultCloth.Id, Is.EqualTo(clothInDb?.Id));
                Assert.That<string>(resultCloth.Name, Is.EqualTo(clothInDb?.Name));
                Assert.That<string>(resultCloth.Brand, Is.EqualTo(clothInDb?.Brand));
            }));
        }

        [Test]
        public async Task GetAllKidsClothes_ShouldReturnCorrectCosmetics()
        {
            //Arrange: create a variable for the category
            var categoryName = "T-Shirts";

            //Act
            var result = await this.shop.GetAllKidsClothes(categoryName);


            //Assert
            var clothsInDb = await this.repo.AllReadonly<Cloth>()
                .Where(c => c.Category.Name == categoryName && c.ForKids == true)
                .ToListAsync();
            Assert.That(result.TotalProductsCount, Is.EqualTo(clothsInDb.Count));

            //Assert the returned house data is correct
            var resultCloth = result.Products.FirstOrDefault();
            Assert.That(resultCloth, Is.Not.Null);

            var clothInDb = clothsInDb.FirstOrDefault();
            Assert.Multiple((TestDelegate)(() =>
            {
                Assert.That(resultCloth.Id, Is.EqualTo(clothInDb?.Id));
                Assert.That<string>(resultCloth.Name, Is.EqualTo(clothInDb?.Name));
                Assert.That<string>(resultCloth.Brand, Is.EqualTo(clothInDb?.Brand));
            }));
        }

        [Test]
        public async Task GetCountInformation_ShouldReturnCorrectCountNumbers()
        {
            //Act
            var result = await this.shop.GetCountInformation();


            //Assert
            var kidsClothsCountInDb = await this.repo.AllReadonly<Cloth>()
                .Where(c => c.ForKids == true)
                .CountAsync();

            var mensClothsCountInDb = await this.repo.AllReadonly<Cloth>()
                .Where(c => c.Gender == Gender.Male)
                .CountAsync();

            var accessoriesCountInDb = await this.repo.AllReadonly<Accessory>()
                .CountAsync();

            var cosmeticsCountInDb = await this.repo.AllReadonly<Cosmetic>()
                .CountAsync();

            Assert.Multiple(() =>
            {
                Assert.That(result.KidsClothsCount, Is.EqualTo(kidsClothsCountInDb));
                Assert.That(result.MensClothsCount, Is.EqualTo(mensClothsCountInDb));
                Assert.That(result.AccessoriesCount, Is.EqualTo(accessoriesCountInDb));
                Assert.That(result.CosmeticsCount, Is.EqualTo(cosmeticsCountInDb));
            });
        }

        [Test]
        public async Task GetAllSizes_ShouldReturnCorrectSizes()
        {
            //Act
            var result = await this.shop.GetAllSizes();

            //Assert
            var sizesInDb = await this.repo.AllReadonly<Size>()
                .ToListAsync();
            Assert.That(result.Count(), Is.EqualTo(sizesInDb.Count));

            //Assert the returned house data is correct
            var resultSize = result.FirstOrDefault();
            Assert.That(resultSize, Is.Not.Null);

            var sizeInDb = sizesInDb.FirstOrDefault();
            Assert.That<string>(resultSize, Is.EqualTo(sizeInDb.SizeNumber));
        }

        [Test]
        public async Task GetAllColors_ShouldReturnCorrectColors()
        {
            //Act
            var result = await this.shop.GetAllColors();

            //Assert
            var colorsInDb = await this.repo.AllReadonly<Color>()
                .ToListAsync();
            Assert.That(result.Count(), Is.EqualTo(colorsInDb.Count));

            //Assert the returned house data is correct
            var resultColor = result.FirstOrDefault();
            Assert.That(resultColor, Is.Not.Null);

            var colorInDb = colorsInDb.FirstOrDefault();
            Assert.That<string>(resultColor, Is.EqualTo(colorInDb.Name));
        }
    }
}
