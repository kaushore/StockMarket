using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AccountAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyCode = table.Column<string>(maxLength: 30, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Turnover = table.Column<double>(nullable: false),
                    CEO = table.Column<string>(nullable: true),
                    Sector = table.Column<string>(nullable: true),
                    WriteUp = table.Column<string>(nullable: true),
                    StockCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyCode);
                });

            migrationBuilder.CreateTable(
                name: "PlannedIPOs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    StockExchange = table.Column<string>(nullable: true),
                    PricePerShare = table.Column<float>(nullable: false),
                    NumberOfShares = table.Column<long>(nullable: false),
                    OpenDateTime = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedIPOs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    SectorId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Brief = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "StockExchanges",
                columns: table => new
                {
                    StockExchangeId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Brief = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockExchanges", x => x.StockExchangeId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 10, nullable: false),
                    Username = table.Column<string>(maxLength: 40, nullable: false),
                    Password = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    Mobile = table.Column<string>(maxLength: 15, nullable: true),
                    Confirmed = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "StockPrice",
                columns: table => new
                {
                    RowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(maxLength: 30, nullable: true),
                    StockExchange = table.Column<string>(nullable: false),
                    CurrentPrice = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrice", x => x.RowID);
                    table.ForeignKey(
                        name: "FK_StockPrice_Company_CompanyCode",
                        column: x => x.CompanyCode,
                        principalTable: "Company",
                        principalColumn: "CompanyCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_CompanyCode",
                table: "StockPrice",
                column: "CompanyCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlannedIPOs");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "StockExchanges");

            migrationBuilder.DropTable(
                name: "StockPrice");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
