using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokh_Design.Migrations
{
    public partial class lamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 4, "Lamp", "Smart lamp with the best design ever" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 9, 4, "https://www.facebook.com/pokhdesign/photos/a.865753123532880/865753080199551/", "/images/lamp.png", true, true, "Those lamps Made by humans in Tunisian fabric", "lamp", 1500m, "Lorem Ipsum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
