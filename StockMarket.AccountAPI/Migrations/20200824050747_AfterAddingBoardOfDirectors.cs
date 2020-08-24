using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarket.AccountAPI.Migrations
{
    public partial class AfterAddingBoardOfDirectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoardOfDirectors",
                table: "Company",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BoardOfDirectors",
                table: "Company");
        }
    }
}
