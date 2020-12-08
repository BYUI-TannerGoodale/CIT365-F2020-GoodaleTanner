using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class PeopleIntegration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Meeting_ClosingPrayerID",
                table: "Meeting",
                column: "ClosingPrayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_OpeningPrayerID",
                table: "Meeting",
                column: "OpeningPrayerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_People_ClosingPrayerID",
                table: "Meeting",
                column: "ClosingPrayerID",
                principalTable: "People",
                principalColumn: "PeopleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_People_OpeningPrayerID",
                table: "Meeting",
                column: "OpeningPrayerID",
                principalTable: "People",
                principalColumn: "PeopleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_People_ClosingPrayerID",
                table: "Meeting");

            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_People_OpeningPrayerID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_ClosingPrayerID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_OpeningPrayerID",
                table: "Meeting");
        }
    }
}
