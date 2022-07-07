﻿// <auto-generated />
using System;
using Advisor6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Advisor6.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Advisor6.Models.Academic_Cert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Academic_Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graduate_Year")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inserting_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specilisit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Academic_Cert");
                });

            modelBuilder.Entity("Advisor6.Models.Administrative_Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Admi_id")
                        .HasColumnType("int");

                    b.Property<int>("AdministrativeNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Administrative_Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataEntryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LadtUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Of_Order")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalId");

                    b.ToTable("Administrative_Orders");
                });

            modelBuilder.Entity("Advisor6.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Advisor6.Models.Employment_info", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Actual_direct_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Contract_expiry_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataEntryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DirectBook_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DirectBook_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmploymentBook_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmploymentBook_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Last_Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainDeptartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Service_Continuation")
                        .HasColumnType("int");

                    b.Property<string>("SubDeptartment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employment_info");
                });

            modelBuilder.Entity("Advisor6.Models.Ifad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IfadActual_Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IfadBookDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IfadBookNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IfadDirectDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_Paid_Sid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_Sid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_Supject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_TravelDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ifad_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InsertingDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inserting_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalId");

                    b.ToTable("Ifad");
                });

            modelBuilder.Entity("Advisor6.Models.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Academic_CertId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BornPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataEntryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Employment_infoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarriedStatus")
                        .HasColumnType("int");

                    b.Property<string>("Nots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VacationsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Academic_CertId");

                    b.HasIndex("Employment_infoId");

                    b.HasIndex("VacationsId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Thanks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Inserting_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("ThanksBook_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanksBook_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thanks_Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thanks_Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thanks_Sid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thanks_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thanks_upper")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalId");

                    b.ToTable("Thanks");
                });

            modelBuilder.Entity("Advisor6.Models.Trining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Inserting_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("T_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("T_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingBookDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingBookNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_DirectDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_Esimate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_GraduteDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_PaidSid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_Sid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Training_StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_WithOrder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalId");

                    b.ToTable("Trining");
                });

            modelBuilder.Entity("Advisor6.Models.Vacations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emp_Vacations_SickTotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Vacations_Total")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inserting_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payment_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sick_Vacation_Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_Book_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_Book_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_Days")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_End_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_No")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_Start_Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacation_WithOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("book_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("order_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vacation_upper")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Advisor6.Models.Administrative_Orders", b =>
                {
                    b.HasOne("Advisor6.Models.Personal", "Personal")
                        .WithMany("Administrative_Orders")
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Ifad", b =>
                {
                    b.HasOne("Advisor6.Models.Personal", "Personal")
                        .WithMany("Ifad")
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Personal", b =>
                {
                    b.HasOne("Advisor6.Models.Academic_Cert", "Academic_Cert")
                        .WithMany("Personal")
                        .HasForeignKey("Academic_CertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Advisor6.Models.Employment_info", "Employment_info")
                        .WithMany("Personal")
                        .HasForeignKey("Employment_infoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Advisor6.Models.Vacations", "Vacations")
                        .WithMany("Personal")
                        .HasForeignKey("VacationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Academic_Cert");

                    b.Navigation("Employment_info");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("Advisor6.Models.Thanks", b =>
                {
                    b.HasOne("Advisor6.Models.Personal", "Personal")
                        .WithMany("Thanks")
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Trining", b =>
                {
                    b.HasOne("Advisor6.Models.Personal", "Personal")
                        .WithMany("Trining")
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Advisor6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Advisor6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Advisor6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Advisor6.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Advisor6.Models.Academic_Cert", b =>
                {
                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Employment_info", b =>
                {
                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Personal", b =>
                {
                    b.Navigation("Administrative_Orders");

                    b.Navigation("Ifad");

                    b.Navigation("Thanks");

                    b.Navigation("Trining");
                });

            modelBuilder.Entity("Advisor6.Models.Vacations", b =>
                {
                    b.Navigation("Personal");
                });
#pragma warning restore 612, 618
        }
    }
}
