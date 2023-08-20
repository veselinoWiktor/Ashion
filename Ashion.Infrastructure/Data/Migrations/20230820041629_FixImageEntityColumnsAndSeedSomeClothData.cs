using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class FixImageEntityColumnsAndSeedSomeClothData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "981383d2-737a-46b8-9f48-3dc8daeb8cdb", "admin@mail.com", false, "Great", "Admin", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEP3RIZzFw6CpIqWrCIEKQIX/yn234QhZfK/eJlSPBG/37J9jHSW9/px+SEs++pVYNw==", null, false, "d219effd-a110-48e6-816d-ebc28561bcd3", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ProductType" },
                values: new object[,]
                {
                    { 1, "T-Shirts", 0 },
                    { 2, "Jeans", 0 },
                    { 3, "Pants", 0 },
                    { 4, "Sweatshirts", 0 },
                    { 5, "Jackets", 0 },
                    { 6, "Shirts", 0 },
                    { 7, "BagsandBackpacks", 1 },
                    { 8, "Sunglasses", 1 },
                    { 9, "Jewelries", 1 },
                    { 10, "Antiagecosmetic", 2 },
                    { 11, "Facecosmetic", 2 },
                    { 12, "SPF", 2 }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beige" },
                    { 2, "Black" },
                    { 3, "Blue" },
                    { 4, "Brown" },
                    { 5, "Gray" },
                    { 6, "Green" },
                    { 7, "Orange" },
                    { 8, "Pink" },
                    { 9, "Purple" },
                    { 10, "Red" },
                    { 11, "White" },
                    { 12, "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "SizeNumber" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "XXL" }
                });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Brand", "CategoryId", "ColorId", "Description", "ForKids", "Gender", "IsActive", "Name", "PackageId", "Price", "Quantity", "ShortContent" },
                values: new object[,]
                {
                    { 1, "Nike", 1, 2, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", false, 1, true, "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10, null },
                    { 2, "Nike", 1, 11, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", false, 1, true, "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10, null },
                    { 3, "Nike", 1, 5, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", false, 1, true, "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10, null },
                    { 4, "Nike", 1, 3, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", false, 1, true, "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10, null },
                    { 5, "Polo Ralph Lauren", 1, 11, "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", false, 1, true, "Тениска", "4C6AC916-30A6-4962-ACA9-67BFA417FF31", 232.90m, 7, null },
                    { 6, "Polo Ralph Lauren", 1, 5, "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", false, 1, true, "Тениска", "4C6AC916-30A6-4962-ACA9-67BFA417FF31", 232.90m, 7, null }
                });

            migrationBuilder.InsertData(
                table: "ClothesSizes",
                columns: new[] { "ClothId", "SizeId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 3 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 5 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 6 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AccessoryId", "ClothId", "CosmeticId", "Url" },
                values: new object[,]
                {
                    { 1, null, 1, null, "https://cdn.aboutstatic.com/file/images/41fb7fb9af1199c00623a77930483763.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600" },
                    { 2, null, 1, null, "https://cdn.aboutstatic.com/file/images/079377b386685bf1b889e751cad816ee.jpg?quality=75&height=800&width=600" },
                    { 3, null, 1, null, "https://cdn.aboutstatic.com/file/images/3f9d53b537dbd3fb3228daaf51b77bf8.jpg?quality=75&height=800&width=600" },
                    { 4, null, 1, null, "https://cdn.aboutstatic.com/file/images/b1826275260cae21fb4f6a9090011bdb.jpg?quality=75&height=1280&width=960" },
                    { 5, null, 1, null, "https://cdn.aboutstatic.com/file/images/b30e9352ac137cb6270de8684c21a24d.jpg?quality=75&height=1280&width=960" },
                    { 6, null, 2, null, "https://cdn.aboutstatic.com/file/images/b17a10676017195d18bbcde5059355ea.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600" },
                    { 7, null, 2, null, "https://cdn.aboutstatic.com/file/images/37ca65e02d5645f4bc4326b3f570ad64.jpg?quality=75&height=800&width=600" },
                    { 8, null, 2, null, "https://cdn.aboutstatic.com/file/images/cc19ba91c5fa92595df252b86b2c2758.jpg?quality=75&height=800&width=600" },
                    { 9, null, 2, null, "https://cdn.aboutstatic.com/file/images/07ad50ea856241d21967c83e1491be93.jpg?quality=75&height=800&width=600" },
                    { 10, null, 2, null, "https://cdn.aboutstatic.com/file/images/dc8bfc499b188b08186f598642dbd8f9.jpg?quality=75&height=1280&width=960" },
                    { 11, null, 3, null, "https://cdn.aboutstatic.com/file/images/72a5e2d58246dd4d26262e225bc4a1c4.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 12, null, 3, null, "https://cdn.aboutstatic.com/file/images/1c31b47d7ee4770cd07a578fa9779b3a.jpg?quality=75&height=1280&width=960" },
                    { 13, null, 3, null, "https://cdn.aboutstatic.com/file/images/1c38ffc11e729f57246d79b0cc94c53b.jpg?quality=75&height=1280&width=960" },
                    { 14, null, 3, null, "https://cdn.aboutstatic.com/file/images/6aa610ebbf8364caef76a582c18c58f4.jpg?quality=75&height=1280&width=960" },
                    { 15, null, 3, null, "https://cdn.aboutstatic.com/file/images/5505ae9c564cb0014f48f3914d243836.jpg?quality=75&height=1280&width=960" },
                    { 16, null, 4, null, "https://cdn.aboutstatic.com/file/images/b86f0e7845dd39e4b5792592370e71af.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600" },
                    { 17, null, 4, null, "https://cdn.aboutstatic.com/file/images/2951c11563182208d3c845c9302a81e2.jpg?quality=75&height=800&width=600" },
                    { 18, null, 4, null, "https://cdn.aboutstatic.com/file/images/549438b849cd1df230f3c3fa8877014d.jpg?quality=75&height=800&width=600" },
                    { 19, null, 4, null, "https://cdn.aboutstatic.com/file/images/90a207c2fb4f787f711b9c60a35554f3.jpg?quality=75&height=1280&width=960" },
                    { 20, null, 4, null, "https://cdn.aboutstatic.com/file/images/79a4134d533ad4cd5d20ce17fa26302f.jpg?quality=75&height=1280&width=960" },
                    { 21, null, 5, null, "https://cdn.aboutstatic.com/file/images/fc28d2511314ccc371d5bd10a4270cab.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 22, null, 5, null, "https://cdn.aboutstatic.com/file/images/3c7e26fd6afdf68dd464f0a18827066e.jpg?quality=75&height=1280&width=960" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AccessoryId", "ClothId", "CosmeticId", "Url" },
                values: new object[,]
                {
                    { 23, null, 5, null, "https://cdn.aboutstatic.com/file/images/dafb99dc5c08a4ebda9bf42670132cd8.jpg?quality=75&height=1280&width=960" },
                    { 24, null, 5, null, "https://cdn.aboutstatic.com/file/images/df5a0005dcf03e327fccb00464883441.jpg?quality=75&height=1280&width=960" },
                    { 25, null, 5, null, "https://cdn.aboutstatic.com/file/images/3c8af8455a8ade177b7b0585d40b3aec.jpg?quality=75&height=1280&width=960" },
                    { 26, null, 6, null, "https://cdn.aboutstatic.com/file/images/b10b0dcfd7fbf7cfde9b9770cd77d9f0.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 27, null, 6, null, "https://cdn.aboutstatic.com/file/images/35b936c2f46329051376d907d4661d75.jpg?quality=75&height=1280&width=960" },
                    { 28, null, 6, null, "https://cdn.aboutstatic.com/file/images/c4fe795025d3b6c27047562e6b07055f.jpg?quality=75&height=1280&width=960" },
                    { 29, null, 6, null, "https://cdn.aboutstatic.com/file/images/2a284b7a30e2a7d75b0bdbed888efa64.jpg?quality=75&height=1280&width=960" },
                    { 30, null, 6, null, "https://cdn.aboutstatic.com/file/images/3161bda02ece8a966cdef0efdcaf9b0d.jpg?quality=75&height=1280&width=960" }
                });
        }
    }
}
