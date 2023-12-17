using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class intitalcreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NflPlay",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<int>(type: "int", nullable: false),
                    GameDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Quarter = table.Column<int>(type: "int", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Second = table.Column<int>(type: "int", nullable: false),
                    OffenseTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefenseTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Down = table.Column<int>(type: "int", nullable: false),
                    ToGo = table.Column<int>(type: "int", nullable: false),
                    YardLine = table.Column<int>(type: "int", nullable: false),
                    SeriesFirstDown = table.Column<bool>(type: "bit", nullable: false),
                    NextScore = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamWin = table.Column<bool>(type: "bit", nullable: false),
                    SeasonYear = table.Column<int>(type: "int", nullable: false),
                    Yards = table.Column<int>(type: "int", nullable: false),
                    Formation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRush = table.Column<bool>(type: "bit", nullable: false),
                    IsPass = table.Column<bool>(type: "bit", nullable: false),
                    IsIncomplete = table.Column<bool>(type: "bit", nullable: false),
                    IsTouchdown = table.Column<bool>(type: "bit", nullable: false),
                    PassType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSack = table.Column<bool>(type: "bit", nullable: false),
                    IsChallenge = table.Column<bool>(type: "bit", nullable: false),
                    IsChallengeReversed = table.Column<bool>(type: "bit", nullable: false),
                    IsMeasurement = table.Column<bool>(type: "bit", nullable: false),
                    IsInterception = table.Column<bool>(type: "bit", nullable: false),
                    IsFumble = table.Column<bool>(type: "bit", nullable: false),
                    IsPenalty = table.Column<bool>(type: "bit", nullable: false),
                    IsTwoPointConversion = table.Column<bool>(type: "bit", nullable: false),
                    TwoPointConSuccess = table.Column<bool>(type: "bit", nullable: false),
                    RushDirection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YardLineFixed = table.Column<int>(type: "int", nullable: false),
                    IsPenaltyAccepted = table.Column<bool>(type: "bit", nullable: false),
                    PenaltyTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsNoPlay = table.Column<bool>(type: "bit", nullable: false),
                    PenaltyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PenaltyYards = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NflPlay", x => x.RecordID);
                });

            migrationBuilder.CreateTable(
                name: "NflPlayType",
                columns: table => new
                {
                    PlayTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NflPlayType", x => x.PlayTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NflPlay_RecordID",
                table: "NflPlay",
                column: "RecordID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NflPlayType_PlayTypeId",
                table: "NflPlayType",
                column: "PlayTypeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NflPlay");

            migrationBuilder.DropTable(
                name: "NflPlayType");
        }
    }
}
