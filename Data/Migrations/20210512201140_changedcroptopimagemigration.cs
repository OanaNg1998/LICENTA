using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class changedcroptopimagemigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87a147af-b10c-4d4e-81eb-210567c902ec", "069e665e-8286-4fd5-98a5-7b6cae39bf71" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1",
                column: "Image",
                value: "https://i.ibb.co/gmxZ7h2/new-crop-top.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Image",
                value: "https://i.ibb.co/QHkrpMh/nike-croptop.jpg");
        }
    }
}
