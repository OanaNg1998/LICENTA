using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class newproductimagechangedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4833ebfa-bcc2-4d22-9068-11950540197f", "c0dda7b1-aa8f-4fc3-bdd6-f408b9077653" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1",
                column: "Image",
                value: "https://i.ibb.co/j5qD0gp/new-crop-top.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
