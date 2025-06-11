using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KotaAndShisanyamaHub.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class addProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.", "https://placehold.co/603x403", "Shisanyama Plater", 85.0 },
                    { 2, "Entre", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.", "https://placehold.co/602x402", "Regular Platter", 69.989999999999995 },
                    { 3, "Meal", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.", "https://placehold.co/601x401", "BunnyChow Latte", 109.98999999999999 },
                    { 4, "Dessert", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer feugiat, mauris ut faucibus rhoncus, tellus orci blandit libero, a fermentum sem diam sagittis lacus. Proin.", "https://placehold.co/600x400", "Sweet Pie", 65.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
