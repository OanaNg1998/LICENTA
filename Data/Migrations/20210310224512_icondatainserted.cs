using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class icondatainserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd6ed4a3-ef67-4a56-b8b5-8d5659a82925", "a00f4137-24a2-47f7-9e34-3cf7aaa40046" });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "3",
                column: "Icon",
                value: "https://i.ibb.co/LJTxjNF/movement-studio.png");

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "4",
                column: "Icon",
                value: "https://i.ibb.co/wy6BzPJ/lotusclub-padesu.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9a9c81d-0f7a-4ac5-a018-6e7374246140", "45534e69-0b5a-4c9a-92d2-83ec4adc2256" });

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "3",
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "4",
                column: "Icon",
                value: null);
        }
    }
}
