﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripLog8_1.Models;

#nullable disable

namespace TripLog8_1.Migrations
{
    [DbContext(typeof(TripLogContext))]
    partial class TripLogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TripLog8_1.Models.Trip", b =>
                {
                    b.Property<int>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripID"));

                    b.Property<string>("Accommodation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccommodationPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ThingToDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThingToDo3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripID");

                    b.ToTable("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
