using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Advisor6.Migrations
{
    public partial class Acadimic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academic_Cert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Academic_Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    College = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specilisit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Graduate_Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inserting_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academic_Cert", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employment_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    Last_Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payment_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_Start_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_End_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Vacations_Total = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sick_Vacation_Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Vacations_SickTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_Book_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_Book_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_WithOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vacation_upper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    book_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inserting_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
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
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Academic_CertId = table.Column<int>(type: "int", nullable: false),
                    Employment_infoId = table.Column<int>(type: "int", nullable: false),
                    VacationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personal_Academic_Cert_Academic_CertId",
                        column: x => x.Academic_CertId,
                        principalTable: "Academic_Cert",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personal_Employment_info_Employment_infoId",
                        column: x => x.Employment_infoId,
                        principalTable: "Employment_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personal_Vacations_VacationsId",
                        column: x => x.VacationsId,
                        principalTable: "Vacations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrative_Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admi_id = table.Column<int>(type: "int", nullable: false),
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
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrative_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrative_Orders_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ifad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ifad_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ifad_Supject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ifad_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ifad_Sid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ifad_Paid_Sid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ifad_TravelDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ifad_Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfadActual_Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfadDirectDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfadBookNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfadBookDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertingDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inserting_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ifad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ifad_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thanks_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thanks_Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanksBook_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanksBook_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thanks_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thanks_Sid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thanks_upper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    book_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inserting_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Thanks_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Training_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_PaidSid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_Sid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_Days = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_DirectDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_GraduteDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Training_Esimate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingBookNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainingBookDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacation_WithOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    U_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    T_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inserting_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trining", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trining_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrative_Orders_PersonalId",
                table: "Administrative_Orders",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ifad_PersonalId",
                table: "Ifad",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Academic_CertId",
                table: "Personal",
                column: "Academic_CertId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_Employment_infoId",
                table: "Personal",
                column: "Employment_infoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personal_VacationsId",
                table: "Personal",
                column: "VacationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Thanks_PersonalId",
                table: "Thanks",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Trining_PersonalId",
                table: "Trining",
                column: "PersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrative_Orders");

            migrationBuilder.DropTable(
                name: "Ifad");

            migrationBuilder.DropTable(
                name: "Thanks");

            migrationBuilder.DropTable(
                name: "Trining");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Academic_Cert");

            migrationBuilder.DropTable(
                name: "Employment_info");

            migrationBuilder.DropTable(
                name: "Vacations");
        }
    }
}
