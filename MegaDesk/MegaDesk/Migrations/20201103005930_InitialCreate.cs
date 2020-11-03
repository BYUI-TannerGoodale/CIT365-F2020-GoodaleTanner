using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(nullable: false),
                    QuoteDate = table.Column<DateTime>(nullable: false),
                    DeskWidth = table.Column<int>(nullable: false),
                    DeskDepth = table.Column<int>(nullable: false),
                    DeskArea = table.Column<int>(nullable: false),
                    Drawers = table.Column<int>(nullable: false),
                    Material = table.Column<string>(nullable: false),
                    ShippingTime = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}
