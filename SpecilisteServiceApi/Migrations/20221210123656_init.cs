using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpecilisteServiceApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    SpecialistID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecialistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpecialistEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialistTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.SpecialistID);
                });

            migrationBuilder.InsertData(
                table: "Specialists",
                columns: new[] { "SpecialistID", "Image", "SpecialistEmail", "SpecialistName", "SpecialistTel" },
                values: new object[] { "da29fdde-5057-4398-b68a-d58a641cc039", "https://ilchiro.org/wp-content/uploads/2019/06/storyblocks-happy-doctor-standing-with-a-laptop_S8lrSrNa-z-1-1280x640.jpg", "Bouzri@gmail.com", "Bouzri Mohamed", "06555891" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specialists");
        }
    }
}
