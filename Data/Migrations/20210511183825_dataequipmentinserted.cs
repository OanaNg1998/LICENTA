using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class dataequipmentinserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d82d282a-ea19-4195-b1c9-5b06081de84b", "0d7ce9e3-315d-4c48-b645-711e46d1a213" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1",
                column: "Gender",
                value: "woman");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "2",
                column: "Gender",
                value: "male");

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Category", "Description", "Gender", "Image", "Price", "ProductName" },
                values: new object[] { "3", "Trousers", null, "woman", "https://i.ibb.co/zVTD7HK/nike-trousers.jpg", 250, "Nike Running Trousers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec9d38b7-87ac-453f-b7c3-442180191e38", "059024ce-e5a9-462b-ae11-61f2db384e7a" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1",
                column: "Gender",
                value: null);

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "2",
                column: "Gender",
                value: null);
        }
    }
}
