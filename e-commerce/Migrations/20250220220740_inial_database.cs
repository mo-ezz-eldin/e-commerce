using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class inial_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(125)", maxLength: 125, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    quatity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Clothing & Apparel" },
                    { 3, "Home & Living" },
                    { 4, "Beauty & Personal Care" },
                    { 5, "Books & Stationery" },
                    { 6, "Toys & Games" },
                    { 7, "Sports & Outdoors" },
                    { 8, "Automotive Parts & Accessories" },
                    { 9, "Groceries & Gourmet Foods" },
                    { 10, "Health & Wellness" },
                    { 11, "Jewelry & Watches" },
                    { 12, "Pet Supplies" },
                    { 13, "Office Supplies" },
                    { 14, "Baby & Kids" },
                    { 15, "Furniture" },
                    { 16, "Art & Crafts" },
                    { 17, "Musical Instruments" },
                    { 18, "Travel & Luggage" },
                    { 19, "Garden & Outdoor" },
                    { 20, "Fitness & Exercise" },
                    { 21, "Watches & Accessories" },
                    { 22, "Party Supplies" },
                    { 23, "Industrial & Scientific" },
                    { 24, "Shoes & Footwear" },
                    { 25, "Seasonal & Holiday Decor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_category_id",
                table: "products",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
