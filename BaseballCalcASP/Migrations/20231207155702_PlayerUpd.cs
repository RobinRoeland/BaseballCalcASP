using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    public partial class PlayerUpd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rugnummer",
                table: "Players",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rugnummer",
                table: "Players");
        }
    }
}
