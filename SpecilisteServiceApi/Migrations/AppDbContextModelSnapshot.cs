﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpecilisteServiceApi.DbContexts;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            id = "edb3c0d3-8391-4776-b358-61451de18e2e",
                            Email = "Fedouache@gmail.com",
                            FirstName = "Fedouache",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            LastName = "Ayoub",
                            Speciality = "Medcin",
                            city = "Tanger",
                            joined = new DateTime(2023, 2, 11, 23, 46, 46, 632, DateTimeKind.Local).AddTicks(7413)
                        },
                        new
                        {
                            id = "00322ad2-3c8e-47e3-be11-d52f96787a45",
                            Email = "Oubari@gmail.com",
                            FirstName = "Hicham",
                            Image = "https://avatars.githubusercontent.com/u/75031773?v=4",
                            LastName = "Oubari",
                            Speciality = "Medcin",
                            Tel = "06555891",
                            city = "Casablanca",
                            joined = new DateTime(2023, 2, 11, 23, 46, 46, 632, DateTimeKind.Local).AddTicks(7474)
                        },
                        new
                        {
                            id = "6cae05fd-20fb-47c2-8b47-b29b21bfeca3",
                            Email = "Bouzri@gmail.com",
                            FirstName = "Bouzri",
                            Image = "https://avatars.githubusercontent.com/u/62290643?v=4",
                            LastName = "Mohamed",
                            Speciality = "Medcin",
                            Tel = "06555891",
                            city = "rabat",
                            joined = new DateTime(2023, 2, 11, 23, 46, 46, 632, DateTimeKind.Local).AddTicks(7501)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
