using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ashion.Infrastructure.Data.Migrations
{
    public partial class seedImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "AccessoryId", "ClothColorId", "ClothId", "CosmeticId", "Url" },
                values: new object[,]
                {
                    { 21, null, 11, 2, null, "https://cdn.aboutstatic.com/file/images/fc28d2511314ccc371d5bd10a4270cab.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 22, null, 11, 2, null, "https://cdn.aboutstatic.com/file/images/3c7e26fd6afdf68dd464f0a18827066e.jpg?quality=75&height=1280&width=960" },
                    { 23, null, 11, 2, null, "https://cdn.aboutstatic.com/file/images/dafb99dc5c08a4ebda9bf42670132cd8.jpg?quality=75&height=1280&width=960" },
                    { 24, null, 11, 2, null, "https://cdn.aboutstatic.com/file/images/df5a0005dcf03e327fccb00464883441.jpg?quality=75&height=1280&width=960" },
                    { 25, null, 11, 2, null, "https://cdn.aboutstatic.com/file/images/3c8af8455a8ade177b7b0585d40b3aec.jpg?quality=75&height=1280&width=960" },
                    { 26, null, 5, 2, null, "https://cdn.aboutstatic.com/file/images/b10b0dcfd7fbf7cfde9b9770cd77d9f0.png?bg=F4F4F5&quality=75&trim=1&height=1280&width=960" },
                    { 27, null, 5, 2, null, "https://cdn.aboutstatic.com/file/images/35b936c2f46329051376d907d4661d75.jpg?quality=75&height=1280&width=960" },
                    { 28, null, 5, 2, null, "https://cdn.aboutstatic.com/file/images/c4fe795025d3b6c27047562e6b07055f.jpg?quality=75&height=1280&width=960" },
                    { 29, null, 5, 2, null, "https://cdn.aboutstatic.com/file/images/2a284b7a30e2a7d75b0bdbed888efa64.jpg?quality=75&height=1280&width=960" },
                    { 30, null, 5, 2, null, "https://cdn.aboutstatic.com/file/images/3161bda02ece8a966cdef0efdcaf9b0d.jpg?quality=75&height=1280&width=960" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
