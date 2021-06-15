using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class addeddatafororder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompleteName",
                table: "OrderHistory",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "OrderHistory",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c0468ef6-0f77-449f-ae17-e9aa921d5af3", "a10b31fa-3ce3-4126-8e9a-05a2231a39d7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompleteName",
                table: "OrderHistory");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "OrderHistory");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f34db3fe-3273-43b2-b626-479e7f85d609", "5bc7ae07-771d-4e32-a6c0-82e5b44105c2" });
        }
    }
}
