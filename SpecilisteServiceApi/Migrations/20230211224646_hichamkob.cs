using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    public partial class hichamkob : Migration
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
                values: new object[] { "00322ad2-3c8e-47e3-be11-d52f96787a45", "Oubari@gmail.com", "Hicham", "https://avatars.githubusercontent.com/u/75031773?v=4", "Oubari", "Medcin", "06555891", "Casablanca", new DateTime(2023, 2, 11, 23, 46, 46, 632, DateTimeKind.Local).AddTicks(7474), null, null });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "6cae05fd-20fb-47c2-8b47-b29b21bfeca3", "Bouzri@gmail.com", "Bouzri", "https://avatars.githubusercontent.com/u/62290643?v=4", "Mohamed", "Medcin", "06555891", "rabat", new DateTime(2023, 2, 11, 23, 46, 46, 632, DateTimeKind.Local).AddTicks(7501), null, null });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "edb3c0d3-8391-4776-b358-61451de18e2e", "Fedouache@gmail.com", "Fedouache", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Ayoub", "Medcin", null, "Tanger", new DateTime(2023, 2, 11, 23, 46, 46, 632, DateTimeKind.Local).AddTicks(7413), null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialists");
        }
    }
}
