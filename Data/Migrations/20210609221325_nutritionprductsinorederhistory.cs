using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class nutritionprductsinorederhistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderHistoryId",
                table: "NutritionProduct",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49f74d8f-afde-4073-a662-93935577e0f0", "3248ac7d-090d-42f9-a05b-b8f4970f08ed" });

            migrationBuilder.CreateIndex(
                name: "IX_NutritionProduct_OrderHistoryId",
                table: "NutritionProduct",
                column: "OrderHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_NutritionProduct_OrderHistory_OrderHistoryId",
                table: "NutritionProduct",
                column: "OrderHistoryId",
                principalTable: "OrderHistory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NutritionProduct_OrderHistory_OrderHistoryId",
                table: "NutritionProduct");

            migrationBuilder.DropIndex(
                name: "IX_NutritionProduct_OrderHistoryId",
                table: "NutritionProduct");

            migrationBuilder.DropColumn(
                name: "OrderHistoryId",
                table: "NutritionProduct");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7f55ad3-ef12-470a-80e1-3f5825993677", "c6191833-0fc1-49ee-b6ff-2a16bd83e810" });
        }
    }
}
