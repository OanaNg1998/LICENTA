using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class nutritionproductsnewtableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionProduct",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Brand = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionProduct", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7f55ad3-ef12-470a-80e1-3f5825993677", "c6191833-0fc1-49ee-b6ff-2a16bd83e810" });

            migrationBuilder.InsertData(
                table: "NutritionProduct",
                columns: new[] { "Id", "Brand", "Category", "Description", "Image", "Price", "ProductName", "Quantity", "Weight" },
                values: new object[,]
                {
                    { "1", "Nutrend", "protein bar", null, "https://i.ibb.co/CzWs55t/protein-bar1.png", 10, "Nutrend Protein Bar", 1, "85g" },
                    { "2", "Pro Nutrition", "protein pouder", null, "https://i.ibb.co/vQQ71dX/protein-powder.jpg", 150, "Whey Protein Powder", 1, "500g" },
                    { "3", "KIND", "protein bar", null, "https://i.ibb.co/swNz3r7/protein-bar2.png", 11, "KIND Protein Bar", 1, "60g" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionProduct");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3072410-a0c3-4aba-94e5-396c1095be9b", "f20f4411-74b0-4d81-8f7d-20dfc2eb9d6c" });
        }
    }
}
