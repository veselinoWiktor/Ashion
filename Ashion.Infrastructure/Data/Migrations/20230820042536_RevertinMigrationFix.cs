using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class RevertinMigrationFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb4f072-ecca-43c9-ab26-c060c6f364e4", 0, "a380c056-0093-4f90-8f74-a66783cb6f06", "admin@mail.com", false, "Great", "Admin", false, null, "admin@mail.com", "admin@mail.com", "AQAAAAEAACcQAAAAEMZwocAApx6oR4P7mLsOPZA+85Q5njm3SjhaEs2xEwBREjSKpsQufRUBwE8csc9F7g==", null, false, "8ef0eca1-8280-4bc6-8ed2-969c93a2fba3", false, "admin@mail.com" });

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
                    { 6, "Polo Ralph Lauren", 1, 5, "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", false, 1, true, "Тениска", "4C6AC916-30A6-4962-ACA9-67BFA417FF31", 232.90m, 7, null },
                    { 7, "JACK & JONES", 1, 11, "This T-Shirt is the best that Jack&Jones have ever created. Perfect for outdoor activities", false, 1, true, "Тениска 'DESTINY'", "EE2D09B8-6FC5-4BBD-857D-669448F72A8E", 34.90m, 5, null },
                    { 8, "JACK & JONES", 1, 1, "This T-Shirt is the best that Jack&Jones have ever created. Perfect for outdoor activities", false, 1, true, "Тениска 'DESTINY'", "EE2D09B8-6FC5-4BBD-857D-669448F72A8E", 34.90m, 7, null },
                    { 9, "JACK & JONES", 1, 9, "This T-Shirt is the best that Jack&Jones have ever created. Perfect for outdoor activities", false, 1, true, "Тениска 'DESTINY'", "EE2D09B8-6FC5-4BBD-857D-669448F72A8E", 34.90m, 4, null },
                    { 10, "TOMMY HILFIGER", 1, 2, "This T-Shirt is the best that Tommy Hilfiger have ever created. Perfect for dates", false, 1, true, "Regular fit Тениска", "EE2D09B8-6FC5-4BBD-857D-669448F72A8E", 157.90m, 10, null }
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
                    { 6, 6 },
                    { 7, 3 },
                    { 7, 4 },
                    { 7, 5 },
                    { 7, 6 },
                    { 8, 6 },
                    { 9, 4 },
                    { 9, 6 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 6 }
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
                    { 9, null, 2, null, "https://cdn.aboutstatic.com/file/images/07ad50ea856241d21967c83e1491be93.jpg?quality=75&height=800&width=600" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AccessoryId", "ClothId", "CosmeticId", "Url" },
                values: new object[,]
                {
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
                    { 22, null, 5, null, "https://cdn.aboutstatic.com/file/images/3c7e26fd6afdf68dd464f0a18827066e.jpg?quality=75&height=1280&width=960" },
                    { 23, null, 5, null, "https://cdn.aboutstatic.com/file/images/dafb99dc5c08a4ebda9bf42670132cd8.jpg?quality=75&height=1280&width=960" },
                    { 24, null, 5, null, "https://cdn.aboutstatic.com/file/images/df5a0005dcf03e327fccb00464883441.jpg?quality=75&height=1280&width=960" },
                    { 25, null, 5, null, "https://cdn.aboutstatic.com/file/images/3c8af8455a8ade177b7b0585d40b3aec.jpg?quality=75&height=1280&width=960" },
                    { 26, null, 6, null, "https://cdn.aboutstatic.com/file/images/b10b0dcfd7fbf7cfde9b9770cd77d9f0.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 27, null, 6, null, "https://cdn.aboutstatic.com/file/images/35b936c2f46329051376d907d4661d75.jpg?quality=75&height=1280&width=960" },
                    { 28, null, 6, null, "https://cdn.aboutstatic.com/file/images/c4fe795025d3b6c27047562e6b07055f.jpg?quality=75&height=1280&width=960" },
                    { 29, null, 6, null, "https://cdn.aboutstatic.com/file/images/2a284b7a30e2a7d75b0bdbed888efa64.jpg?quality=75&height=1280&width=960" },
                    { 30, null, 6, null, "https://cdn.aboutstatic.com/file/images/3161bda02ece8a966cdef0efdcaf9b0d.jpg?quality=75&height=1280&width=960" },
                    { 31, null, 7, null, "https://cdn.aboutstatic.com/file/images/258423227ecc44cb4cdbb41e57e656f2.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600" },
                    { 32, null, 7, null, "https://cdn.aboutstatic.com/file/images/a6344783637f5937ddf5d9699a5a8f12.jpg?quality=75&height=800&width=600" },
                    { 33, null, 7, null, "https://cdn.aboutstatic.com/file/images/f01e30d0b4f7ccf5bcaf61fc68e5b838.jpg?quality=75&height=800&width=600" },
                    { 34, null, 7, null, "https://cdn.aboutstatic.com/file/images/40cf25a28a7cbcf08ed079ca5176f0f6.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600" },
                    { 35, null, 7, null, "https://cdn.aboutstatic.com/file/images/3ef6d9fb83b7c0b635b8c0431e4f9102.jpg?quality=75&height=800&width=600" },
                    { 36, null, 8, null, "https://cdn.aboutstatic.com/file/images/f1902b10ef43f455ab97a199ef2a49d8.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600" },
                    { 37, null, 8, null, "https://cdn.aboutstatic.com/file/images/f182b881952160eb880e93cefa1bdc9e.jpg?quality=75&height=800&width=600" },
                    { 38, null, 8, null, "https://cdn.aboutstatic.com/file/images/be38c887c1c2c359c1a5bf1d28a3f16d.jpg?quality=75&height=800&width=600" },
                    { 39, null, 8, null, "https://cdn.aboutstatic.com/file/images/3f7fa09043eedf9986ad45c678f6e947.jpg?quality=75&height=800&width=600" },
                    { 40, null, 8, null, "https://cdn.aboutstatic.com/file/images/475771302f14331cf86c8ad272be0063.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600" },
                    { 41, null, 9, null, "https://cdn.aboutstatic.com/file/images/8dd6b7b1b470dc23803bfaa486b96825.jpg?brightness=0.96&quality=75&trim=1&height=800&width=600" },
                    { 42, null, 9, null, "https://cdn.aboutstatic.com/file/images/fa1d8451d2b0b2bb07f643a8005100eb.jpg?quality=75&height=800&width=600" },
                    { 43, null, 9, null, "https://cdn.aboutstatic.com/file/images/8a2d61d2a5db11c521946aee0a055a8e.jpg?quality=75&height=800&width=600" },
                    { 44, null, 9, null, "https://cdn.aboutstatic.com/file/images/ff4800322ffc172e7705f822c2dd5563.jpg?quality=75&height=800&width=600" },
                    { 45, null, 9, null, "https://cdn.aboutstatic.com/file/images/a1cc594f75f232f67fa173629ed28f55.jpg?brightness=0.96&quality=75&trim=1&height=800&width=609" },
                    { 46, null, 10, null, "https://cdn.aboutstatic.com/file/245901138103834e96a78477d8903bde?bg=F4F4F5&quality=75&trim=1&height=800&width=600" },
                    { 47, null, 10, null, "https://cdn.aboutstatic.com/file/802d382f8d7cd0a7dfc945015249f43e?quality=75&height=800&width=600" },
                    { 48, null, 10, null, "https://cdn.aboutstatic.com/file/d0876225b26b0a0dc8cd26cc21cf73f4?quality=75&height=800&width=600" },
                    { 49, null, 10, null, "https://cdn.aboutstatic.com/file/3d8abe90e24d82b097914fcd9b5396ea?quality=75&height=800&width=600" },
                    { 50, null, 10, null, "https://cdn.aboutstatic.com/file/4b060eadcf59359bf754f9a935a88c80?quality=75&height=800&width=600" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 10, 6 });

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
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50);

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
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

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
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
