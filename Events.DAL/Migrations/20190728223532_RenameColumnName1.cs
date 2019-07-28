using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.DAL.Migrations
{
    public partial class RenameColumnName1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ReciepentsUsers",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ReciepentsUsers",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReciepentsUsers",
                table: "ReciepentsUsers",
                column: "ID");
        }
    }
}
