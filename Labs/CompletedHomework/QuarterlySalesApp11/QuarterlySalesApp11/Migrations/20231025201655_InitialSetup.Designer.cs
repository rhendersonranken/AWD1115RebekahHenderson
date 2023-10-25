﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuarterlySalesApp11.Models;

#nullable disable

namespace QuarterlySalesApp11.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20231025201655_InitialSetup")]
    partial class InitialSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuarterlySalesApp11.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<DateTime?>("DOB")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfHire")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ManagerID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            DOB = new DateTime(1956, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ada",
                            LastName = "Lovelace",
                            ManagerID = 0
                        },
                        new
                        {
                            EmployeeID = 2,
                            DOB = new DateTime(1966, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Katherine",
                            LastName = "Johnson",
                            ManagerID = 1
                        },
                        new
                        {
                            EmployeeID = 3,
                            DOB = new DateTime(1975, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfHire = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Grace",
                            LastName = "Hopper",
                            ManagerID = 1
                        });
                });

            modelBuilder.Entity("QuarterlySalesApp11.Models.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleID"));

                    b.Property<int?>("Amount")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int?>("Quarter")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SaleID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleID = 1,
                            Amount = 23456,
                            EmployeeID = 2,
                            Quarter = 4,
                            Year = 2019
                        },
                        new
                        {
                            SaleID = 2,
                            Amount = 34567,
                            EmployeeID = 2,
                            Quarter = 1,
                            Year = 2020
                        },
                        new
                        {
                            SaleID = 3,
                            Amount = 19876,
                            EmployeeID = 3,
                            Quarter = 4,
                            Year = 2019
                        },
                        new
                        {
                            SaleID = 4,
                            Amount = 31009,
                            EmployeeID = 3,
                            Quarter = 1,
                            Year = 2020
                        });
                });

            modelBuilder.Entity("QuarterlySalesApp11.Models.Sale", b =>
                {
                    b.HasOne("QuarterlySalesApp11.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}