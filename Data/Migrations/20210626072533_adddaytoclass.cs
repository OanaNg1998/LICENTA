using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class adddaytoclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Trainings",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d073012-78c0-48e9-8c88-270e09ece597", "310c7322-471a-45c0-b368-bb4c07dae67e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Trainings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1792daa9-6765-421b-83bc-fcf6bd068aea", "b23ee3c6-15bf-4417-b42a-c4cebacbd3cc" });
        }
    }
}
