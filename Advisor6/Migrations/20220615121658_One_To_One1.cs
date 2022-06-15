using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class One_To_One1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Last_Job",
                table: "Employment_info",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Last_Job",
                table: "Employment_info");
        }
    }
}
