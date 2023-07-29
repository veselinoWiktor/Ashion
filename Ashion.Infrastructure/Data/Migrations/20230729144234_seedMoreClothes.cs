using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class seedMoreClothes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Cosmetics",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Clothes",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Accessories",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "ForKids", "Gender", "IsActive", "Name", "Price", "Quantity", "ShortContent" },
                values: new object[] { 2, "Polo Ralph Lauren", 1, "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", false, 0, true, "Тениска", 232.90m, 7, null });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AccessoryId", "ClothColorId", "ClothId", "CosmeticId", "Url" },
                values: new object[,]
                {
                    { 6, null, 11, 1, null, "https://cdn.aboutstatic.com/file/images/b17a10676017195d18bbcde5059355ea.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600" },
                    { 7, null, 11, 1, null, "https://cdn.aboutstatic.com/file/images/37ca65e02d5645f4bc4326b3f570ad64.jpg?quality=75&height=800&width=600" },
                    { 8, null, 11, 1, null, "https://cdn.aboutstatic.com/file/images/cc19ba91c5fa92595df252b86b2c2758.jpg?quality=75&height=800&width=600" },
                    { 9, null, 11, 1, null, "https://cdn.aboutstatic.com/file/images/07ad50ea856241d21967c83e1491be93.jpg?quality=75&height=800&width=600" },
                    { 10, null, 11, 1, null, "https://cdn.aboutstatic.com/file/images/dc8bfc499b188b08186f598642dbd8f9.jpg?quality=75&height=1280&width=960" },
                    { 11, null, 5, 1, null, "https://cdn.aboutstatic.com/file/images/72a5e2d58246dd4d26262e225bc4a1c4.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 12, null, 5, 1, null, "https://cdn.aboutstatic.com/file/images/1c31b47d7ee4770cd07a578fa9779b3a.jpg?quality=75&height=1280&width=960" },
                    { 13, null, 5, 1, null, "https://cdn.aboutstatic.com/file/images/1c38ffc11e729f57246d79b0cc94c53b.jpg?quality=75&height=1280&width=960" },
                    { 14, null, 5, 1, null, "https://cdn.aboutstatic.com/file/images/6aa610ebbf8364caef76a582c18c58f4.jpg?quality=75&height=1280&width=960" },
                    { 15, null, 5, 1, null, "https://cdn.aboutstatic.com/file/images/5505ae9c564cb0014f48f3914d243836.jpg?quality=75&height=1280&width=960" },
                    { 16, null, 3, 1, null, "https://cdn.aboutstatic.com/file/images/b86f0e7845dd39e4b5792592370e71af.png?bg=F4F4F5&quality=75&trim=1&height=800&width=600" },
                    { 17, null, 3, 1, null, "https://cdn.aboutstatic.com/file/images/2951c11563182208d3c845c9302a81e2.jpg?quality=75&height=800&width=600" },
                    { 18, null, 3, 1, null, "https://cdn.aboutstatic.com/file/images/549438b849cd1df230f3c3fa8877014d.jpg?quality=75&height=800&width=600" },
                    { 19, null, 3, 1, null, "https://cdn.aboutstatic.com/file/images/90a207c2fb4f787f711b9c60a35554f3.jpg?quality=75&height=1280&width=960" },
                    { 20, null, 3, 1, null, "https://cdn.aboutstatic.com/file/images/79a4134d533ad4cd5d20ce17fa26302f.jpg?quality=75&height=1280&width=960" }
                });

            migrationBuilder.InsertData(
                table: "ClothesColors",
                columns: new[] { "ClothId", "ColorId" },
                values: new object[,]
                {
                    { 2, 5 },
                    { 2, 11 }
                });

            migrationBuilder.InsertData(
                table: "ClothesSizes",
                columns: new[] { "ClothId", "SizeId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClothesColors",
                keyColumns: new[] { "ClothId", "ColorId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesColors",
                keyColumns: new[] { "ClothId", "ColorId" },
                keyValues: new object[] { 2, 11 });

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
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 2, 6 });

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
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Cosmetics",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Clothes",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Accessories",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);
        }
    }
}
