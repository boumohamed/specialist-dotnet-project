﻿// <auto-generated />
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
    [Migration("20221216195523_specialists-seeds")]
    partial class specialistsseeds
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
                    b.Property<string>("SpecialistID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialistEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialistName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpecialistTel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialistID");

                    b.ToTable("Specialists");

                    b.HasData(
                        new
                        {
                            SpecialistID = "f10ef00f-8fd1-4273-bbf3-2a36b442c8d5",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            SpecialistEmail = "Bouzri@gmail.com",
                            SpecialistName = "Bouzri Mohamed",
                            SpecialistTel = "06555891"
                        },
                        new
                        {
                            SpecialistID = "9dd6513a-0475-4737-8b29-1c833d005d91",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            SpecialistEmail = "sanae@gmail.com",
                            SpecialistName = "Bouzri Sanae",
                            SpecialistTel = "06555891"
                        },
                        new
                        {
                            SpecialistID = "32db0f1d-69f5-4214-ae34-0154903f7137",
                            Image = "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg",
                            SpecialistEmail = "jana@gmail.com",
                            SpecialistName = "Bouzri Jana",
                            SpecialistTel = "06555891"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}