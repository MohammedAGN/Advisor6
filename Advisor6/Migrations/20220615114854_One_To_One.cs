using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class One_To_One : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrative_Orders",
                columns: table => new
                {
                    Admi_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdministrativeNo = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    Administrative_Order_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type_Of_Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LadtUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrative_Orders", x => x.Admi_id);
                });

            migrationBuilder.CreateTable(
                name: "Employment_info",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainDeptartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDeptartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service_Continuation = table.Column<int>(type: "int", nullable: false),
                    Job_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Job_Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentBook_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmploymentBook_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DirectBook_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectBook_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Actual_direct_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contract_expiry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment_info", x => x.PersonalId);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    MarriedStatus = table.Column<int>(type: "int", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BornPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.PersonalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrative_Orders");

            migrationBuilder.DropTable(
                name: "Employment_info");

            migrationBuilder.DropTable(
                name: "Personal");
        }
    }
}
