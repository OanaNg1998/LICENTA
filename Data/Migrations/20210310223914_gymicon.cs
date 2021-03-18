using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class gymicon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Gym",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9a9c81d-0f7a-4ac5-a018-6e7374246140", "45534e69-0b5a-4c9a-92d2-83ec4adc2256" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Gym");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad1cac20-b871-4cc6-925c-8b182d061f2c", "96ff2763-9043-4ded-ad09-9eebe3c90a6a" });
        }
    }
}
