using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(CreateImages());
        }

        private static List<object> CreateImages()
        {
            return new List<object>()
            {
                new 
                {
                    Id = 1,
                    Url = "https://cdn.aboutstatic.com/file/images/41fb7fb9af1199c00623a77930483763.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 1
                },
                new
                {
                    Id = 2,
                    Url = "https://cdn.aboutstatic.com/file/images/079377b386685bf1b889e751cad816ee.jpg?quality=75&height=800&width=600",
                    ClothId = 1
                },
                new
                {
                    Id = 3,
                    Url = "https://cdn.aboutstatic.com/file/images/3f9d53b537dbd3fb3228daaf51b77bf8.jpg?quality=75&height=800&width=600",
                    ClothId = 1
                },
                new
                {
                    Id = 4,
                    Url = "https://cdn.aboutstatic.com/file/images/b1826275260cae21fb4f6a9090011bdb.jpg?quality=75&height=1280&width=960",
                    ClothId = 1
                },
                new
                {
                    Id = 5,
                    Url = "https://cdn.aboutstatic.com/file/images/b30e9352ac137cb6270de8684c21a24d.jpg?quality=75&height=1280&width=960",
                    ClothId = 1
                },
                new
                {
                    Id = 6,
                    Url = "https://cdn.aboutstatic.com/file/images/b17a10676017195d18bbcde5059355ea.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 2
                },
                new
                {
                    Id = 7,
                    Url = "https://cdn.aboutstatic.com/file/images/37ca65e02d5645f4bc4326b3f570ad64.jpg?quality=75&height=800&width=600",
                    ClothId = 2
                },
                new
                {
                    Id = 8,
                    Url = "https://cdn.aboutstatic.com/file/images/cc19ba91c5fa92595df252b86b2c2758.jpg?quality=75&height=800&width=600",
                    ClothId = 2
                },
                new
                {
                    Id = 9,
                    Url = "https://cdn.aboutstatic.com/file/images/07ad50ea856241d21967c83e1491be93.jpg?quality=75&height=800&width=600",
                    ClothId = 2
                },

                new
                {
                    Id = 10,
                    Url = "https://cdn.aboutstatic.com/file/images/dc8bfc499b188b08186f598642dbd8f9.jpg?quality=75&height=1280&width=960",
                    ClothId = 2
                },
                new
                {
                    Id = 11,
                    Url = "https://cdn.aboutstatic.com/file/images/72a5e2d58246dd4d26262e225bc4a1c4.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960",
                    ClothId = 3
                },
                new
                {
                    Id = 12,
                    Url = "https://cdn.aboutstatic.com/file/images/1c31b47d7ee4770cd07a578fa9779b3a.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new
                {
                    Id = 13,
                    Url = "https://cdn.aboutstatic.com/file/images/1c38ffc11e729f57246d79b0cc94c53b.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new
                {
                    Id = 14,
                    Url = "https://cdn.aboutstatic.com/file/images/6aa610ebbf8364caef76a582c18c58f4.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new
                {
                    Id = 15,
                    Url = "https://cdn.aboutstatic.com/file/images/5505ae9c564cb0014f48f3914d243836.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new
                {
                    Id = 16,
                    Url = "https://cdn.aboutstatic.com/file/images/b86f0e7845dd39e4b5792592370e71af.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 4
                },
                new
                {
                    Id = 17,
                    Url = "https://cdn.aboutstatic.com/file/images/2951c11563182208d3c845c9302a81e2.jpg?quality=75&height=800&width=600",
                    ClothId = 4
                },
                new
                {
                    Id = 18,
                    Url = "https://cdn.aboutstatic.com/file/images/549438b849cd1df230f3c3fa8877014d.jpg?quality=75&height=800&width=600",
                    ClothId = 4
                },
                new
                {
                    Id = 19,
                    Url = "https://cdn.aboutstatic.com/file/images/90a207c2fb4f787f711b9c60a35554f3.jpg?quality=75&height=1280&width=960",
                    ClothId = 4
                },
                new
                {
                    Id = 20,
                    Url = "https://cdn.aboutstatic.com/file/images/79a4134d533ad4cd5d20ce17fa26302f.jpg?quality=75&height=1280&width=960",
                    ClothId = 4
                },
                new
                {
                    Id = 21,
                    Url = "https://cdn.aboutstatic.com/file/images/fc28d2511314ccc371d5bd10a4270cab.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960",
                    ClothId = 5
                },
                new
                {
                    Id = 22,
                    Url = "https://cdn.aboutstatic.com/file/images/3c7e26fd6afdf68dd464f0a18827066e.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new
                {
                    Id = 23,
                    Url = "https://cdn.aboutstatic.com/file/images/dafb99dc5c08a4ebda9bf42670132cd8.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new
                {
                    Id = 24,
                    Url = "https://cdn.aboutstatic.com/file/images/df5a0005dcf03e327fccb00464883441.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new
                {
                    Id = 25,
                    Url = "https://cdn.aboutstatic.com/file/images/3c8af8455a8ade177b7b0585d40b3aec.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new
                {
                    Id = 26,
                    Url = "https://cdn.aboutstatic.com/file/images/b10b0dcfd7fbf7cfde9b9770cd77d9f0.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960",
                    ClothId = 6
                },
                new
                {
                    Id = 27,
                    Url = "https://cdn.aboutstatic.com/file/images/35b936c2f46329051376d907d4661d75.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new
                {
                    Id = 28,
                    Url = "https://cdn.aboutstatic.com/file/images/c4fe795025d3b6c27047562e6b07055f.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new
                {
                    Id = 29,
                    Url = "https://cdn.aboutstatic.com/file/images/2a284b7a30e2a7d75b0bdbed888efa64.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new
                {
                    Id = 30,
                    Url = "https://cdn.aboutstatic.com/file/images/3161bda02ece8a966cdef0efdcaf9b0d.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                }
            };
        }
    }
}
