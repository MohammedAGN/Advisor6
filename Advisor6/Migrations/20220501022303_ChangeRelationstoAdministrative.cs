using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class ChangeRelationstoAdministrative : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrative_Orders_Employment_info_Employment_infoEmployee_id",
                table: "Administrative_Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Employment_info_Personal_PersonalId",
                table: "Employment_info");

            migrationBuilder.DropIndex(
                name: "IX_Employment_info_PersonalId",
                table: "Employment_info");

            migrationBuilder.DropIndex(
                name: "IX_Administrative_Orders_Employment_infoEmployee_id",
                table: "Administrative_Orders");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Employment_info");

            migrationBuilder.DropColumn(
                name: "Employment_infoEmployee_id",
                table: "Administrative_Orders");

            migrationBuilder.AddColumn<int>(
                name: "Employment_infoId",
                table: "Administrative_Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrative_Orders_Employment_info_Employment_infoId",
                table: "Administrative_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Administrative_Orders_Employment_infoId",
                table: "Administrative_Orders");

            migrationBuilder.DropColumn(
                name: "Employment_infoId",
                table: "Administrative_Orders");

            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Employment_info",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Employment_infoEmployee_id",
                table: "Administrative_Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employment_info_PersonalId",
                table: "Employment_info",
                column: "PersonalId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_info_Personal_PersonalId",
                table: "Employment_info",
                column: "PersonalId",
                principalTable: "Personal",
                principalColumn: "PersonalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
