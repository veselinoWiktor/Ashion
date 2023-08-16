using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class AddCreationDateToReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "674d55fb-8d95-4334-b891-221f192d4306", "AQAAAAEAACcQAAAAECP9fNbhr16nLGeMnjH1T7KwGXM9k5IhxqJkhf1TH8QFr+2p8oJjw2n6YUPfxauCZA==", "1091f9c6-3dfc-4159-a2e0-7f0bdcb864ee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be4bddd7-35c4-48ee-b365-eb9c445feec9", "AQAAAAEAACcQAAAAEDfMniu2/1m/Kqk5Z07NB0jsYTS27RJGlOlbXaomI7jcXV7ZR5vgK0Y2ofJ1sdvqNA==", "dec8ae47-2abd-438c-95b3-9506d41fdf2c" });
        }
    }
}
