using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class PersonalIdRelationWithAdministrativeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Administrative_Orders_PersonalId",
                table: "Administrative_Orders",
                column: "PersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrative_Orders_Personal_PersonalId",
                table: "Administrative_Orders",
                column: "PersonalId",
                principalTable: "Personal",
                principalColumn: "P_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrative_Orders_Personal_PersonalId",
                table: "Administrative_Orders");

            migrationBuilder.DropIndex(
                name: "IX_Administrative_Orders_PersonalId",
                table: "Administrative_Orders");
        }
    }
}
