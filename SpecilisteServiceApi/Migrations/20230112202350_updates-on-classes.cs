using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    public partial class updatesonclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    joined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speciality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "2e8a581b-d936-446c-9864-f0ca32c6c879", "Bouzri@gmail.com", "Mohamed", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri", "Medcin", "06555891", "Casablanca", new DateTime(2023, 1, 12, 21, 23, 49, 799, DateTimeKind.Local).AddTicks(4974), null, null });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "5d99e14e-b1a2-4e52-ba77-d2efb7eaae15", "jana@gmail.com", "Jana", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri", "Medcin", null, "Tanger", new DateTime(2023, 1, 12, 21, 23, 49, 799, DateTimeKind.Local).AddTicks(5068), null, null });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "f04ac6be-1b5e-46a3-8e59-10ef49b3fea6", "sanae@gmail.com", "Sanae", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri", "Medcin", "06555891", "rabat", new DateTime(2023, 1, 12, 21, 23, 49, 799, DateTimeKind.Local).AddTicks(5051), null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialists");
        }
    }
}
