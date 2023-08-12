using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class FixProductsColorAndAddPackageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_Categories_CategoryId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Cosmetics_Categories_CategoryId",
                table: "Cosmetics");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Accessories_AccessoryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Colors_ClothColorId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cosmetics_CosmeticId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Accessories_AccessoryId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ClothesColors");

            migrationBuilder.DropIndex(
                name: "IX_Images_ClothColorId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ClothesSizes",
                keyColumns: new[] { "ClothId", "SizeId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DropColumn(
                name: "ClothColorId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Clothes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PackageId",
                table: "Clothes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ColorId", "PackageId" },
                values: new object[] { 2, "DE3F5A08-C6EA-473D-977E-975E80D2C664" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "ColorId", "Description", "Name", "PackageId", "Price", "Quantity" },
                values: new object[] { "Nike", 11, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10 });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "Id", "Brand", "CategoryId", "ColorId", "Description", "ForKids", "Gender", "IsActive", "Name", "PackageId", "Price", "Quantity", "ShortContent" },
                values: new object[,]
                {
                    { 3, "Nike", 1, 5, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", false, 0, true, "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10, null },
                    { 4, "Nike", 1, 3, "Този продукт е направен от рециклирани материали, които са създадени чрез повторна употреба на материали преди или след тяхната употреба. Използването на рециклирани материали в продуктите намалява количеството на суровините и свързаните с тях отпадъци, енергия и вода при производството на първични материали.", false, 0, true, "Tениска", "DE3F5A08-C6EA-473D-977E-975E80D2C664", 58.90m, 10, null },
                    { 5, "Polo Ralph Lauren", 1, 11, "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", false, 0, true, "Тениска", "4C6AC916-30A6-4962-ACA9-67BFA417FF31", 232.90m, 7, null },
                    { 6, "Polo Ralph Lauren", 1, 5, "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", false, 0, true, "Тениска", "4C6AC916-30A6-4962-ACA9-67BFA417FF31", 232.90m, 7, null }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "ClothId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "ClothId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "ClothId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "ClothId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "ClothId",
                value: 2);

            migrationBuilder.InsertData(
                table: "ClothesSizes",
                columns: new[] { "ClothId", "SizeId" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "ClothId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "ClothId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                column: "ClothId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                column: "ClothId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                column: "ClothId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "ClothId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "ClothId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "ClothId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                column: "ClothId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                column: "ClothId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                column: "ClothId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                column: "ClothId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                column: "ClothId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                column: "ClothId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                column: "ClothId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                column: "ClothId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                column: "ClothId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                column: "ClothId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                column: "ClothId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                column: "ClothId",
                value: 6);

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ColorId",
                table: "Clothes",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Categories_CategoryId",
                table: "Accessories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Colors_ColorId",
                table: "Clothes",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cosmetics_Categories_CategoryId",
                table: "Cosmetics",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Accessories_AccessoryId",
                table: "Images",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cosmetics_CosmeticId",
                table: "Images",
                column: "CosmeticId",
                principalTable: "Cosmetics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Accessories_AccessoryId",
                table: "Reviews",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews",
                column: "CosmeticId",
                principalTable: "Cosmetics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accessories_Categories_CategoryId",
                table: "Accessories");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Colors_ColorId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cosmetics_Categories_CategoryId",
                table: "Cosmetics");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Accessories_AccessoryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cosmetics_CosmeticId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Accessories_AccessoryId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_ColorId",
                table: "Clothes");

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

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Clothes");

            migrationBuilder.AddColumn<int>(
                name: "ClothColorId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClothesColors",
                columns: table => new
                {
                    ClothId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesColors", x => new { x.ClothId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_ClothesColors_Clothes_ClothId",
                        column: x => x.ClothId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothesColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "Name", "Price", "Quantity" },
                values: new object[] { "Polo Ralph Lauren", "This T-Shirt is the best that Polo have ever created. Perfect for outdoor activities", "Тениска", 232.90m, 7 });

            migrationBuilder.InsertData(
                table: "ClothesColors",
                columns: new[] { "ClothId", "ColorId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 5 },
                    { 1, 11 },
                    { 2, 5 },
                    { 2, 11 }
                });

            migrationBuilder.InsertData(
                table: "ClothesSizes",
                columns: new[] { "ClothId", "SizeId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 5 },
                    { 2, 6 }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClothColorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClothColorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClothColorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClothColorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClothColorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClothColorId", "ClothId" },
                values: new object[] { 5, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ClothColorId",
                table: "Images",
                column: "ClothColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesColors_ColorId",
                table: "ClothesColors",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Categories_CategoryId",
                table: "Accessories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cosmetics_Categories_CategoryId",
                table: "Cosmetics",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Accessories_AccessoryId",
                table: "Images",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Colors_ClothColorId",
                table: "Images",
                column: "ClothColorId",
                principalTable: "Colors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cosmetics_CosmeticId",
                table: "Images",
                column: "CosmeticId",
                principalTable: "Cosmetics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Accessories_AccessoryId",
                table: "Reviews",
                column: "AccessoryId",
                principalTable: "Accessories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews",
                column: "CosmeticId",
                principalTable: "Cosmetics",
                principalColumn: "Id");
        }
    }
}
