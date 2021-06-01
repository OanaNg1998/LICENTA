using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class adingbrandtoequipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Equipment",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "955f3413-a9b7-4d9f-ad7d-4cdf7902d80a", "ffb7807e-21b3-4770-9e46-44a9a5a49533" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1",
                column: "Brand",
                value: "Nike");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "2",
                column: "Brand",
                value: "Adidas");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "3",
                column: "Brand",
                value: "Nike");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Equipment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "833d5f5c-778f-404c-b31e-4665d29e786c", "74c675ab-0476-4dbf-857d-8fcd9905eabb" });
        }
    }
}
