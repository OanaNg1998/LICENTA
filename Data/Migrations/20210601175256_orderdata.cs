using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class orderdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderHistoryId",
                table: "Equipment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderHistory",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    EquipmentId = table.Column<string>(nullable: true),
                    ProductNumber = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<int>(nullable: false),
                    DeliveryAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistory", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f34db3fe-3273-43b2-b626-479e7f85d609", "5bc7ae07-771d-4e32-a6c0-82e5b44105c2" });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_OrderHistoryId",
                table: "Equipment",
                column: "OrderHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_OrderHistory_OrderHistoryId",
                table: "Equipment",
                column: "OrderHistoryId",
                principalTable: "OrderHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_OrderHistory_OrderHistoryId",
                table: "Equipment");

            migrationBuilder.DropTable(
                name: "OrderHistory");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_OrderHistoryId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "OrderHistoryId",
                table: "Equipment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9bf9694-9860-4d2e-8003-420f4216ce27", "4d9c523d-c019-4bb6-a8fd-9f0fbf019a93" });
        }
    }
}
