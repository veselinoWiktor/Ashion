using Ashion.Infrastructure.Common;
using Ashion.Infrastructure.Data.Entities;
using Ashion.Infrastructure.Data.Enums;
using Ashion.Tests.Mocks;
using AutoMapper;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Tests.UnitTests
{
    public class UnitTestsBase
    {
        protected IRepository repo;
        protected IMapper mapper;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            this.repo = new Repository(DatabaseMock.Instance);
            this.mapper = MapperMock.Instance;
            this.SeedDataBase();
        }

        [OneTimeTearDown]
        public void TearDownBase()
        {
            this.repo.Dispose();
        }

        public Accessory Accessory { get; private set; } = null!;

        public Cosmetic Cosmetic { get; private set; } = null!;

        public Cloth MenCloth { get; private set; } = null!;

        public User User { get; private set; } = null!;


        private void SeedDataBase()
        {

            this.User = new User()
            {
                Id = "TestUserId",
                Email = "test@test.bg",
                FirstName = "Test",
                LastName = "Tester"
            };
            repo.Add(this.User);

            this.Accessory = new Accessory()
            {
                Id = 1,
                Name = "glasse",
                Brand = "Ray Ban",
                Price = 200,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "Sunglasses", ProductType = ProductType.Accessory},
                Quantity = 5,
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
            this.repo.Add(this.Accessory);

            this.Cosmetic = new Cosmetic()
            {
                Id = 1,
                Name = "Cosmetic Name",
                Brand = "Cosmetic Brand",
                Price = 60,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "SPF", ProductType = ProductType.Cosmetics },
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
            this.repo.Add(this.Cosmetic);

            this.MenCloth = new Cloth()
            {
                Id = 1,
                Name = "Cloth Name",
                Brand = "Cloth Brand",
                Price = 250,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "T-Shirts", ProductType = ProductType.Cloth },
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
                    Name = "Red",
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
            this.repo.Add(this.MenCloth);

            var cloth = new Cloth()
            {
                Id = 2,
                Name = "Cloth Name",
                Brand = "Cloth Brand",
                Price = 250,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "T-Shirts", ProductType = ProductType.Cloth },
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
                    Name = "Green",
                },
                ForKids = false,
                Gender = Gender.Female,
                PackageId = "6BC5D723-8110-4B2B-9417-7317724292A5",
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
            this.repo.Add(cloth);

            cloth = new Cloth()
            {
                Id = 3,
                Name = "Cloth Name",
                Brand = "Cloth Brand",
                Price = 250,
                ShortContent = "this is a test short content",
                Description = "This is a test description.",
                Category = new Category { Name = "T-Shirts", ProductType = ProductType.Cloth },
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
                    Name = "Green",
                },
                ForKids = true,
                Gender = Gender.Female,
                PackageId = "6BC5D723-8110-4B2B-9417-7317724292A8",
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
            this.repo.Add(cloth);

            //Accessory Review
            var review = new Review()
            {
                Id = 1,
                Title = "Test Title",
                Content = "Test content. test content",
                CreationDate = DateTime.UtcNow,
                FromUser = this.User,
                AccessoryId = 1,
            };
            this.repo.Add(review);

            //MensCloth Review
            review = new Review()
            {
                Id = 2,
                Title = "Test Title",
                Content = "Test content. test content",
                CreationDate = DateTime.UtcNow,
                FromUser = this.User,
                ClothId = 1,
            };
            this.repo.Add(review);

            //Cosmetic Review
            review = new Review()
            {
                Id = 3,
                Title = "Test Title",
                Content = "Test content. test content",
                CreationDate = DateTime.UtcNow,
                FromUser = this.User,
                CosmeticId = this.Cosmetic.Id,
            };
            this.repo.Add(review);

            this.repo.SaveChanges();
        }
    }
}
