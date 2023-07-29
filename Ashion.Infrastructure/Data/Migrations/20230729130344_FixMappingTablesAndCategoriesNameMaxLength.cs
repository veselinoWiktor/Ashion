using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class FixMappingTablesAndCategoriesNameMaxLength : Migration
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
                name: "FK_Images_Cosmetics_CosmeticId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Accessories_AccessoryId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ClothesColors");

            migrationBuilder.DropTable(
                name: "ClothesSizes");

            migrationBuilder.AddColumn<int>(
                name: "ClothColorId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

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

            migrationBuilder.CreateTable(
                name: "ClothesSizes",
                columns: table => new
                {
                    ClothId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesSizes", x => new { x.ClothId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_ClothesSizes_Clothes_ClothId",
                        column: x => x.ClothId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothesSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ClothColorId",
                table: "Images",
                column: "ClothColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesColors_ColorId",
                table: "ClothesColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesSizes_SizeId",
                table: "ClothesSizes",
                column: "SizeId");

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
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews",
                column: "CosmeticId",
                principalTable: "Cosmetics",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ClothesColors");

            migrationBuilder.DropTable(
                name: "ClothesSizes");

            migrationBuilder.DropIndex(
                name: "IX_Images_ClothColorId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ClothColorId",
                table: "Images");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateTable(
                name: "ClothColor",
                columns: table => new
                {
                    ClothsId = table.Column<int>(type: "int", nullable: false),
                    ColorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothColor", x => new { x.ClothsId, x.ColorsId });
                    table.ForeignKey(
                        name: "FK_ClothColor_Clothes_ClothsId",
                        column: x => x.ClothsId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothColor_Colors_ColorsId",
                        column: x => x.ColorsId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClothSize",
                columns: table => new
                {
                    ClothsId = table.Column<int>(type: "int", nullable: false),
                    SizesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothSize", x => new { x.ClothsId, x.SizesId });
                    table.ForeignKey(
                        name: "FK_ClothSize_Clothes_ClothsId",
                        column: x => x.ClothsId,
                        principalTable: "Clothes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothSize_Sizes_SizesId",
                        column: x => x.SizesId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothColor_ColorsId",
                table: "ClothColor",
                column: "ColorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothSize_SizesId",
                table: "ClothSize",
                column: "SizesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accessories_Categories_CategoryId",
                table: "Accessories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Reviews_Cosmetics_CosmeticId",
                table: "Reviews",
                column: "CosmeticId",
                principalTable: "Cosmetics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
