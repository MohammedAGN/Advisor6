using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class _2PersonalIdRelationWithAdministrativeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalId",
                table: "Administrative_Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Administrative_Orders");
        }
    }
}
