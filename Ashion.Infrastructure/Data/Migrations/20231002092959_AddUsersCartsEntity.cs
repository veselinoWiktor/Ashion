using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class AddUsersCartsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersCarts",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCarts", x => new { x.UserId, x.ProductId, x.ProductType });
                    table.ForeignKey(
                        name: "FK_UsersCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71500453-855b-44f4-81cf-a46b41e3a16e", "AQAAAAEAACcQAAAAEGy5tfrUn4wB9XCRBt3u2O2cyfczVNohw//TqmKjiKlReCPvYPetuD0XXB9OBvXcoA==", "969f0115-de78-4426-a467-49b0dba3129e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersCarts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1af5cda-4c4e-467e-8a72-2dab9e79ac14", "AQAAAAEAACcQAAAAEDaOt21PMN+BzW/QrrORI0hjxBUdk2enbR28dXnvmA67CruhTxHTrvCeKY+K48PF6A==", "52560057-8429-4008-9890-a974ffb06bba" });
        }
    }
}
