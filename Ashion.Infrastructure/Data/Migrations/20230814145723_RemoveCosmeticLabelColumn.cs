using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class RemoveCosmeticLabelColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                table: "Cosmetics");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4bddd7-35c4-48ee-b365-eb9c445feec9", "AQAAAAEAACcQAAAAEDfMniu2/1m/Kqk5Z07NB0jsYTS27RJGlOlbXaomI7jcXV7ZR5vgK0Y2ofJ1sdvqNA==", "dec8ae47-2abd-438c-95b3-9506d41fdf2c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Cosmetics",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c906c4d-2cc5-4956-868b-b0e7921bf03b", "AQAAAAEAACcQAAAAEFdyGOjj88J28O44JpUYpkQFCRLPWJjo8PW0IFN3A9XylSQznJ0JFb2z4I9xWaofXA==", "d421f01b-19a4-4757-9261-348dd87fb73c" });
        }
    }
}
