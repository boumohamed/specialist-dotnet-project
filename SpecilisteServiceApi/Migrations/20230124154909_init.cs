using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "id",
                keyValue: "2e8a581b-d936-446c-9864-f0ca32c6c879");

            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "id",
                keyValue: "5d99e14e-b1a2-4e52-ba77-d2efb7eaae15");

            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "id",
                keyValue: "f04ac6be-1b5e-46a3-8e59-10ef49b3fea6");

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "2ca13c16-72e1-42bb-b75b-c106e84036de", "sanae@gmail.com", "Sanae", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri", "Medcin", "06555891", "rabat", new DateTime(2023, 1, 24, 7, 49, 9, 546, DateTimeKind.Local).AddTicks(3836), null, null });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "92754c30-1149-4d99-b379-0e0d2a4d0373", "jana@gmail.com", "Jana", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri", "Medcin", null, "Tanger", new DateTime(2023, 1, 24, 7, 49, 9, 546, DateTimeKind.Local).AddTicks(3848), null, null });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "id", "Email", "FirstName", "Image", "LastName", "Speciality", "Tel", "city", "joined", "street", "zipCode" },
                values: new object[] { "afc9354c-f919-438b-9a69-2aa689477dba", "Bouzri@gmail.com", "Mohamed", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri", "Medcin", "06555891", "Casablanca", new DateTime(2023, 1, 24, 7, 49, 9, 546, DateTimeKind.Local).AddTicks(3778), null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "id",
                keyValue: "2ca13c16-72e1-42bb-b75b-c106e84036de");

            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "id",
                keyValue: "92754c30-1149-4d99-b379-0e0d2a4d0373");

            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "id",
                keyValue: "afc9354c-f919-438b-9a69-2aa689477dba");

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
    }
}
