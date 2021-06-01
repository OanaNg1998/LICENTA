using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class gendermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Equipment",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec9d38b7-87ac-453f-b7c3-442180191e38", "059024ce-e5a9-462b-ae11-61f2db384e7a" });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Gender", "Image", "Price", "ProductName" },
                values: new object[] { "2", "Shorts", null, null, "https://i.ibb.co/GTBzGt4/adidas-man-shorts.jpg", 200, "Adidas Man Shorts" });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Gender", "Image", "Price", "ProductName" },
                values: new object[] { "1", "T-shirt", null, null, "https://i.ibb.co/QHkrpMh/nike-croptop.jpg", 100, "Nike Crop Top" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Equipment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccdb9ff6-04eb-4d1e-9a39-5d6a9074ead8", "c5fda9cb-7a2f-472f-b707-6f1b56581174" });
        }
    }
}
