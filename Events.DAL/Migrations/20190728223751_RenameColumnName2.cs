using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.DAL.Migrations
{
    public partial class RenameColumnName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId1",
                table: "ReciepentsUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReciepentsUsers_EventId1",
                table: "ReciepentsUsers",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ReciepentsUsers_Events_EventId1",
                table: "ReciepentsUsers",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReciepentsUsers_Events_EventId1",
                table: "ReciepentsUsers");

            migrationBuilder.DropIndex(
                name: "IX_ReciepentsUsers_EventId1",
                table: "ReciepentsUsers");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "ReciepentsUsers");
        }
    }
}
