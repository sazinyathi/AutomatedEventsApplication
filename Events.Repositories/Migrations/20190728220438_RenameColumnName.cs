using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.DAL.Migrations
{
    public partial class RenameColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ReciepentsUsers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UsersID",
                table: "ReciepentsUsers",
                newName: "EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ReciepentsUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "ReciepentsUsers",
                newName: "UsersID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers",
                column: "UsersID");
        }
    }
}
