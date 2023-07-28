using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class RemoveRelationalTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ClothesColors");

            migrationBuilder.DropTable(
                name: "ClothesSizes");

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
                name: "IX_ClothesColors_ColorId",
                table: "ClothesColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesSizes_SizeId",
                table: "ClothesSizes",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "ClothColor");

            migrationBuilder.DropTable(
                name: "ClothSize");

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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothesColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothesSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothesColors_ColorId",
                table: "ClothesColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesSizes_SizeId",
                table: "ClothesSizes",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_FromUserId",
                table: "Reviews",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
