using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class EmployeeListAdministrative_Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
