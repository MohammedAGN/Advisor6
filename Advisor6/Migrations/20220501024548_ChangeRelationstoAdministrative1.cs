using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class ChangeRelationstoAdministrative1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrative_Orders_Employment_info_Employment_infoId",
                table: "Administrative_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Administrative_Orders_Employment_infoId",
                table: "Administrative_Orders");

            migrationBuilder.RenameColumn(
                name: "Employment_infoId",
                table: "Administrative_Orders",
                newName: "Employee_id");

            migrationBuilder.AddColumn<int>(
                name: "Employment_infoEmployee_id",
                table: "Administrative_Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Administrative_Orders_Employment_infoEmployee_id",
                table: "Administrative_Orders",
                column: "Employment_infoEmployee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrative_Orders_Employment_info_Employment_infoEmployee_id",
                table: "Administrative_Orders",
                column: "Employment_infoEmployee_id",
                principalTable: "Employment_info",
                principalColumn: "Employee_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrative_Orders_Employment_info_Employment_infoEmployee_id",
                table: "Administrative_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Administrative_Orders_Employment_infoEmployee_id",
                table: "Administrative_Orders");

            migrationBuilder.DropColumn(
                name: "Employment_infoEmployee_id",
                table: "Administrative_Orders");

            migrationBuilder.RenameColumn(
                name: "Employee_id",
                table: "Administrative_Orders",
                newName: "Employment_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrative_Orders_Employment_infoId",
                table: "Administrative_Orders",
                column: "Employment_infoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrative_Orders_Employment_info_Employment_infoId",
                table: "Administrative_Orders",
                column: "Employment_infoId",
                principalTable: "Employment_info",
                principalColumn: "Employee_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
