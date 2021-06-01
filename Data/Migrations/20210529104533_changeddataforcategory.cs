using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class changeddataforcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9bf9694-9860-4d2e-8003-420f4216ce27", "4d9c523d-c019-4bb6-a8fd-9f0fbf019a93" });

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "1",
                column: "Category",
                value: "tshirt");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "2",
                column: "Category",
                value: "shorts");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "3",
                column: "Category",
                value: "trousers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "Category",
                value: "T-shirt");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "2",
                column: "Category",
                value: "Shorts");

            migrationBuilder.UpdateData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: "3",
                column: "Category",
                value: "Trousers");
        }
    }
}
