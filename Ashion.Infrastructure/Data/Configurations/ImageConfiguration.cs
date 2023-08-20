using Ashion.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ashion.Infrastructure.Data.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(CreateImages());
        }

        private static List<Image> CreateImages()
        {
            return new List<Image>()
            {
                new Image
                {
                    Id = 1,
                    Url = "https://cdn.aboutstatic.com/file/images/41fb7fb9af1199c00623a77930483763.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 1
                },
                new Image
                {
                    Id = 2,
                    Url = "https://cdn.aboutstatic.com/file/images/079377b386685bf1b889e751cad816ee.jpg?quality=75&height=800&width=600",
                    ClothId = 1
                },
                new Image
                {
                    Id = 3,
                    Url = "https://cdn.aboutstatic.com/file/images/3f9d53b537dbd3fb3228daaf51b77bf8.jpg?quality=75&height=800&width=600",
                    ClothId = 1
                },
                new Image
                {
                    Id = 4,
                    Url = "https://cdn.aboutstatic.com/file/images/b1826275260cae21fb4f6a9090011bdb.jpg?quality=75&height=1280&width=960",
                    ClothId = 1
                },
                new Image
                {
                    Id = 5,
                    Url = "https://cdn.aboutstatic.com/file/images/b30e9352ac137cb6270de8684c21a24d.jpg?quality=75&height=1280&width=960",
                    ClothId = 1
                },
                new Image
                {
                    Id = 6,
                    Url = "https://cdn.aboutstatic.com/file/images/b17a10676017195d18bbcde5059355ea.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 2
                },
                new Image
                { 
                    Id = 7,
                    Url = "https://cdn.aboutstatic.com/file/images/37ca65e02d5645f4bc4326b3f570ad64.jpg?quality=75&height=800&width=600",
                    ClothId = 2
                },
                new Image
                {
                    Id = 8,
                    Url = "https://cdn.aboutstatic.com/file/images/cc19ba91c5fa92595df252b86b2c2758.jpg?quality=75&height=800&width=600",
                    ClothId = 2
                },
                new Image
                {
                    Id = 9,
                    Url = "https://cdn.aboutstatic.com/file/images/07ad50ea856241d21967c83e1491be93.jpg?quality=75&height=800&width=600",
                    ClothId = 2
                },
                new Image
                {
                    Id = 10,
                    Url = "https://cdn.aboutstatic.com/file/images/dc8bfc499b188b08186f598642dbd8f9.jpg?quality=75&height=1280&width=960",
                    ClothId = 2
                },
                new Image
                {
                    Id = 11,
                    Url = "https://cdn.aboutstatic.com/file/images/72a5e2d58246dd4d26262e225bc4a1c4.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960",
                    ClothId = 3
                },
                new Image
                {
                    Id = 12,
                    Url = "https://cdn.aboutstatic.com/file/images/1c31b47d7ee4770cd07a578fa9779b3a.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new Image
                {
                    Id = 13,
                    Url = "https://cdn.aboutstatic.com/file/images/1c38ffc11e729f57246d79b0cc94c53b.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new Image
                {
                    Id = 14,
                    Url = "https://cdn.aboutstatic.com/file/images/6aa610ebbf8364caef76a582c18c58f4.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new Image
                {
                    Id = 15,
                    Url = "https://cdn.aboutstatic.com/file/images/5505ae9c564cb0014f48f3914d243836.jpg?quality=75&height=1280&width=960",
                    ClothId = 3
                },
                new Image
                {
                    Id = 16,
                    Url = "https://cdn.aboutstatic.com/file/images/b86f0e7845dd39e4b5792592370e71af.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 4
                },
                new Image
                {
                    Id = 17,
                    Url = "https://cdn.aboutstatic.com/file/images/2951c11563182208d3c845c9302a81e2.jpg?quality=75&height=800&width=600",
                    ClothId = 4
                },
                new Image
                {
                    Id = 18,
                    Url = "https://cdn.aboutstatic.com/file/images/549438b849cd1df230f3c3fa8877014d.jpg?quality=75&height=800&width=600",
                    ClothId = 4
                },
                new Image
                {
                    Id = 19,
                    Url = "https://cdn.aboutstatic.com/file/images/90a207c2fb4f787f711b9c60a35554f3.jpg?quality=75&height=1280&width=960",
                    ClothId = 4
                },
                new Image
                {
                    Id = 20,
                    Url = "https://cdn.aboutstatic.com/file/images/79a4134d533ad4cd5d20ce17fa26302f.jpg?quality=75&height=1280&width=960",
                    ClothId = 4
                },
                new Image
                {
                    Id = 21,
                    Url = "https://cdn.aboutstatic.com/file/images/fc28d2511314ccc371d5bd10a4270cab.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960",
                    ClothId = 5
                },
                new Image
                {
                    Id = 22,
                    Url = "https://cdn.aboutstatic.com/file/images/3c7e26fd6afdf68dd464f0a18827066e.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new Image
                {
                    Id = 23,
                    Url = "https://cdn.aboutstatic.com/file/images/dafb99dc5c08a4ebda9bf42670132cd8.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new Image
                {
                    Id = 24,
                    Url = "https://cdn.aboutstatic.com/file/images/df5a0005dcf03e327fccb00464883441.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new Image
                {
                    Id = 25,
                    Url = "https://cdn.aboutstatic.com/file/images/3c8af8455a8ade177b7b0585d40b3aec.jpg?quality=75&height=1280&width=960",
                    ClothId = 5
                },
                new Image
                {
                    Id = 26,
                    Url = "https://cdn.aboutstatic.com/file/images/b10b0dcfd7fbf7cfde9b9770cd77d9f0.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960",
                    ClothId = 6
                },
                new Image
                {
                    Id = 27,
                    Url = "https://cdn.aboutstatic.com/file/images/35b936c2f46329051376d907d4661d75.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new Image
                {
                    Id = 28,
                    Url = "https://cdn.aboutstatic.com/file/images/c4fe795025d3b6c27047562e6b07055f.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new Image
                {
                    Id = 29,
                    Url = "https://cdn.aboutstatic.com/file/images/2a284b7a30e2a7d75b0bdbed888efa64.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new Image
                {
                    Id = 30,
                    Url = "https://cdn.aboutstatic.com/file/images/3161bda02ece8a966cdef0efdcaf9b0d.jpg?quality=75&height=1280&width=960",
                    ClothId = 6
                },
                new Image
                {
                    Id = 31,
                    Url = "https://cdn.aboutstatic.com/file/images/258423227ecc44cb4cdbb41e57e656f2.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600",
                    ClothId = 7
                },
                new Image
                {
                    Id = 32,
                    Url = "https://cdn.aboutstatic.com/file/images/a6344783637f5937ddf5d9699a5a8f12.jpg?quality=75&height=800&width=600",
                    ClothId = 7
                },
                new Image
                {
                    Id = 33,
                    Url = "https://cdn.aboutstatic.com/file/images/f01e30d0b4f7ccf5bcaf61fc68e5b838.jpg?quality=75&height=800&width=600",
                    ClothId = 7
                },
                new Image
                {
                    Id = 34,
                    Url = "https://cdn.aboutstatic.com/file/images/40cf25a28a7cbcf08ed079ca5176f0f6.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600",
                    ClothId = 7
                },
                new Image
                {
                    Id = 35,
                    Url = "https://cdn.aboutstatic.com/file/images/3ef6d9fb83b7c0b635b8c0431e4f9102.jpg?quality=75&height=800&width=600",
                    ClothId = 7
                },
                new Image
                {
                    Id = 36,
                    Url = "https://cdn.aboutstatic.com/file/images/f1902b10ef43f455ab97a199ef2a49d8.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600",
                    ClothId = 8
                },
                new Image
                {
                    Id = 37,
                    Url = "https://cdn.aboutstatic.com/file/images/f182b881952160eb880e93cefa1bdc9e.jpg?quality=75&height=800&width=600",
                    ClothId = 8
                },
                new Image
                {
                    Id = 38,
                    Url = "https://cdn.aboutstatic.com/file/images/be38c887c1c2c359c1a5bf1d28a3f16d.jpg?quality=75&height=800&width=600",
                    ClothId = 8
                },
                new Image
                {
                    Id = 39,
                    Url = "https://cdn.aboutstatic.com/file/images/3f7fa09043eedf9986ad45c678f6e947.jpg?quality=75&height=800&width=600",
                    ClothId = 8
                },
                new Image
                {
                    Id = 40,
                    Url = "https://cdn.aboutstatic.com/file/images/475771302f14331cf86c8ad272be0063.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600",
                    ClothId = 8
                },
                new Image
                {
                    Id = 41,
                    Url = "https://cdn.aboutstatic.com/file/images/8dd6b7b1b470dc23803bfaa486b96825.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600",
                    ClothId = 9
                },
                new Image
                {
                    Id = 42,
                    Url = "https://cdn.aboutstatic.com/file/images/fa1d8451d2b0b2bb07f643a8005100eb.jpg?quality=75&height=800&width=600",
                    ClothId = 9
                },
                new Image
                {
                    Id = 43,
                    Url = "https://cdn.aboutstatic.com/file/images/8a2d61d2a5db11c521946aee0a055a8e.jpg?quality=75&height=800&width=600",
                    ClothId = 9
                },
                new Image
                {
                    Id = 44,
                    Url = "https://cdn.aboutstatic.com/file/images/ff4800322ffc172e7705f822c2dd5563.jpg?quality=75&height=800&width=600",
                    ClothId = 9
                },
                new Image
                {
                    Id = 45,
                    Url = "https://cdn.aboutstatic.com/file/images/a1cc594f75f232f67fa173629ed28f55.jpg?brightness=0.96&quality=75&trim=1&height=800&width=609",
                    ClothId = 9
                },
                new Image
                {
                    Id = 46,
                    Url = "https://cdn.aboutstatic.com/file/245901138103834e96a78477d8903bde?bg=F4F4F5&quality=75&trim=1&height=800&width=600",
                    ClothId = 10
                },
                new Image
                {
                    Id = 47,
                    Url = "https://cdn.aboutstatic.com/file/802d382f8d7cd0a7dfc945015249f43e?quality=75&height=800&width=600",
                    ClothId = 10
                },
                new Image
                {
                    Id = 48,
                    Url = "https://cdn.aboutstatic.com/file/d0876225b26b0a0dc8cd26cc21cf73f4?quality=75&height=800&width=600",
                    ClothId = 10
                },
                new Image
                {
                    Id = 49,
                    Url = "https://cdn.aboutstatic.com/file/3d8abe90e24d82b097914fcd9b5396ea?quality=75&height=800&width=600",
                    ClothId = 10
                },
                new Image
                {
                    Id = 50,
                    Url = "https://cdn.aboutstatic.com/file/4b060eadcf59359bf754f9a935a88c80?quality=75&height=800&width=600",
                    ClothId = 10
                }
            };
        }
    }
}
