﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpecilisteServiceApi.DbContexts;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230112202350_updates-on-classes")]
    partial class updatesonclasses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SpecilisteServiceApi.Models.Specialist", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("joined")
                        .HasColumnType("datetime2");

                    b.Property<string>("street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Specialists");

                    b.HasData(
                        new
                        {
                            id = "2e8a581b-d936-446c-9864-f0ca32c6c879",
                            Email = "Bouzri@gmail.com",
                            FirstName = "Mohamed",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            LastName = "Bouzri",
                            Speciality = "Medcin",
                            Tel = "06555891",
                            city = "Casablanca",
                            joined = new DateTime(2023, 1, 12, 21, 23, 49, 799, DateTimeKind.Local).AddTicks(4974)
                        },
                        new
                        {
                            id = "f04ac6be-1b5e-46a3-8e59-10ef49b3fea6",
                            Email = "sanae@gmail.com",
                            FirstName = "Sanae",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            LastName = "Bouzri",
                            Speciality = "Medcin",
                            Tel = "06555891",
                            city = "rabat",
                            joined = new DateTime(2023, 1, 12, 21, 23, 49, 799, DateTimeKind.Local).AddTicks(5051)
                        },
                        new
                        {
                            id = "5d99e14e-b1a2-4e52-ba77-d2efb7eaae15",
                            Email = "jana@gmail.com",
                            FirstName = "Jana",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            LastName = "Bouzri",
                            Speciality = "Medcin",
                            city = "Tanger",
                            joined = new DateTime(2023, 1, 12, 21, 23, 49, 799, DateTimeKind.Local).AddTicks(5068)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
