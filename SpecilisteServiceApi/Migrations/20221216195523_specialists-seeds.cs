using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    public partial class specialistsseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "SpecialistID",
                keyValue: "da29fdde-5057-4398-b68a-d58a641cc039");

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "SpecialistID", "Image", "SpecialistEmail", "SpecialistName", "SpecialistTel" },
                values: new object[] { "32db0f1d-69f5-4214-ae34-0154903f7137", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "jana@gmail.com", "Bouzri Jana", "06555891" });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "SpecialistID", "Image", "SpecialistEmail", "SpecialistName", "SpecialistTel" },
                values: new object[] { "9dd6513a-0475-4737-8b29-1c833d005d91", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "sanae@gmail.com", "Bouzri Sanae", "06555891" });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "SpecialistID", "Image", "SpecialistEmail", "SpecialistName", "SpecialistTel" },
                values: new object[] { "f10ef00f-8fd1-4273-bbf3-2a36b442c8d5", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri@gmail.com", "Bouzri Mohamed", "06555891" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "SpecialistID",
                keyValue: "32db0f1d-69f5-4214-ae34-0154903f7137");

            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "SpecialistID",
                keyValue: "9dd6513a-0475-4737-8b29-1c833d005d91");

            migrationBuilder.DeleteData(
                table: "Specialists",
                keyColumn: "SpecialistID",
                keyValue: "f10ef00f-8fd1-4273-bbf3-2a36b442c8d5");

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "SpecialistID", "Image", "SpecialistEmail", "SpecialistName", "SpecialistTel" },
                values: new object[] { "da29fdde-5057-4398-b68a-d58a641cc039", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri@gmail.com", "Bouzri Mohamed", "06555891" });
        }
    }
}
