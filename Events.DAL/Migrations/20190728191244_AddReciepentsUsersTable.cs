using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.DAL.Migrations
{
    public partial class AddReciepentsUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReciepentsUsers",
                columns: table => new
                {
                    UsersID = table.Column<int>(nullable: false),
                    ActiveRecipients = table.Column<string>(nullable: false),
                    NotActiveRecipients = table.Column<string>(nullable: false),
                    IsEmailSent = table.Column<bool>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReciepentsUsers", x => x.UsersID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReciepentsUsers");
        }
    }
}
