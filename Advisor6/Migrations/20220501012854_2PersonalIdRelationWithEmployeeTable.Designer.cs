﻿// <auto-generated />
using System;
using Advisor6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Advisor6.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220501012854_2PersonalIdRelationWithEmployeeTable")]
    partial class _2PersonalIdRelationWithEmployeeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Advisor6.Models.Administrative_Orders", b =>
                {
                    b.Property<int>("Admi_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type_Of_Order")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Admi_id");

                    b.ToTable("Administrative_Orders");
                });

            modelBuilder.Entity("Advisor6.Models.Employment_info", b =>
                {
                    b.Property<int>("Employee_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("MainDeptartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nots")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Service_Continuation")
                        .HasColumnType("int");

                    b.Property<string>("SubDeptartment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Employee_id");

                    b.HasIndex("PersonalId");

                    b.ToTable("Employment_info");
                });

            modelBuilder.Entity("Advisor6.Models.Personal", b =>
                {
                    b.Property<int>("P_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("P_id");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("Advisor6.Models.Employment_info", b =>
                {
                    b.HasOne("Advisor6.Models.Personal", "Personal")
                        .WithMany()
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });
#pragma warning restore 612, 618
        }
    }
}
