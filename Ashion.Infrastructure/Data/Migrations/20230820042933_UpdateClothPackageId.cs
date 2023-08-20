using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class UpdateClothPackageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af4c0295-1871-4f99-bdd4-6e56cb3ffdfc", "AQAAAAEAACcQAAAAELjSovncUTeCrJuBRS0nfvYKcPoMycCXti8Oln9bpqMsxDvcQQzNGpGMGASjT7a5Bw==", "972993bf-376f-4fe0-a9d8-c246b91a5048" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 10,
                column: "PackageId",
                value: "705B0C81-D166-4127-8C1A-D956CA797BDB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a380c056-0093-4f90-8f74-a66783cb6f06", "AQAAAAEAACcQAAAAEMZwocAApx6oR4P7mLsOPZA+85Q5njm3SjhaEs2xEwBREjSKpsQufRUBwE8csc9F7g==", "8ef0eca1-8280-4bc6-8ed2-969c93a2fba3" });

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "Id",
                keyValue: 10,
                column: "PackageId",
                value: "EE2D09B8-6FC5-4BBD-857D-669448F72A8E");
        }
    }
}
