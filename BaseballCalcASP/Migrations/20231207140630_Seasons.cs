using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseballCalcASP.Migrations
{
    public partial class Seasons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerKey = table.Column<int>(type: "int", nullable: false),
                    GamesPlayed = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    PlateAppearences = table.Column<int>(type: "int", nullable: false),
                    HStrikeOuts = table.Column<int>(type: "int", nullable: false),
                    Hits = table.Column<int>(type: "int", nullable: false),
                    Singles = table.Column<int>(type: "int", nullable: false),
                    Doubles = table.Column<int>(type: "int", nullable: false),
                    Triples = table.Column<int>(type: "int", nullable: false),
                    HomeRuns = table.Column<int>(type: "int", nullable: false),
                    BaseOnBalls = table.Column<int>(type: "int", nullable: false),
                    HitByPitch = table.Column<int>(type: "int", nullable: false),
                    SacrificeFlies = table.Column<int>(type: "int", nullable: false),
                    SacrificeHits = table.Column<int>(type: "int", nullable: false),
                    CaughtStealing = table.Column<int>(type: "int", nullable: false),
                    StolenBases = table.Column<int>(type: "int", nullable: false),
                    Runs = table.Column<int>(type: "int", nullable: false),
                    Errors = table.Column<int>(type: "int", nullable: false),
                    DoublePlays = table.Column<int>(type: "int", nullable: false),
                    TriplePlays = table.Column<int>(type: "int", nullable: false),
                    PassedBalls = table.Column<int>(type: "int", nullable: false),
                    PStrikeOuts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Season");
        }
    }
}
