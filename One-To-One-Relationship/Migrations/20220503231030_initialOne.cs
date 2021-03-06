using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace One_To_One_Relationship.Migrations
{
    public partial class initialOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Employment_info",
                columns: table => new
                {
                    Employment_infoId = table.Column<int>(type: "int", nullable: false)
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
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment_info", x => x.Employment_infoId);
                    table.ForeignKey(
                        name: "FK_Employment_info_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    Employee_id = table.Column<int>(type: "int", nullable: false),
                    Employment_infoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrative_Orders", x => x.Admi_id);
                    table.ForeignKey(
                        name: "FK_Administrative_Orders_Employment_info_Employment_infoId",
                        column: x => x.Employment_infoId,
                        principalTable: "Employment_info",
                        principalColumn: "Employment_infoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Administrative_Orders_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrative_Orders_Employment_infoId",
                table: "Administrative_Orders",
                column: "Employment_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrative_Orders_PersonalId",
                table: "Administrative_Orders",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Employment_info_PersonalId",
                table: "Employment_info",
                column: "PersonalId",
                unique: true);
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
