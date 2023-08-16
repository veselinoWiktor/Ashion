using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class addForeignKeysToReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "981383d2-737a-46b8-9f48-3dc8daeb8cdb", "AQAAAAEAACcQAAAAEP3RIZzFw6CpIqWrCIEKQIX/yn234QhZfK/eJlSPBG/37J9jHSW9/px+SEs++pVYNw==", "d219effd-a110-48e6-816d-ebc28561bcd3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "674d55fb-8d95-4334-b891-221f192d4306", "AQAAAAEAACcQAAAAECP9fNbhr16nLGeMnjH1T7KwGXM9k5IhxqJkhf1TH8QFr+2p8oJjw2n6YUPfxauCZA==", "1091f9c6-3dfc-4159-a2e0-7f0bdcb864ee" });
        }
    }
}
