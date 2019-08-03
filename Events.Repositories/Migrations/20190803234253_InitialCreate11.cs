using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Events.Repositories.Migrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventCatetogory",
                columns: table => new
                {
                    EventTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventCatetogory", x => x.EventTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    EventName = table.Column<string>(maxLength: 50, nullable: false),
                    EventDescription = table.Column<string>(maxLength: 50, nullable: false),
                    EventLocation = table.Column<string>(maxLength: 50, nullable: false),
                    ActiveRecipientsJson = table.Column<string>(nullable: true),
                    NotActiveRecipientsJson = table.Column<string>(nullable: true),
                    RowCreateDate = table.Column<DateTime>(nullable: false),
                    IsMailSent = table.Column<bool>(nullable: false),
                    EventTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventCatetogory_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventCatetogory",
                        principalColumn: "EventTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId",
                table: "Events",
                column: "EventTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "EventCatetogory");
        }
    }
}
