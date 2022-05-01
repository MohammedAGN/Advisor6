using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class _2PersonalIdRelationWithEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employment_info_PersonalId",
                table: "Employment_info",
                column: "PersonalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employment_info_Personal_PersonalId",
                table: "Employment_info",
                column: "PersonalId",
                principalTable: "Personal",
                principalColumn: "P_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employment_info_Personal_PersonalId",
                table: "Employment_info");

            migrationBuilder.DropIndex(
                name: "IX_Employment_info_PersonalId",
                table: "Employment_info");
        }
    }
}
