using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class defensiveteam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DefensiveTeamId",
                table: "NflPlay",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NflPlay_DefensiveTeamId",
                table: "NflPlay",
                column: "DefensiveTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflTeams_DefensiveTeamId",
                table: "NflPlay",
                column: "DefensiveTeamId",
                principalTable: "NflTeams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflTeams_DefensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropIndex(
                name: "IX_NflPlay_DefensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropColumn(
                name: "DefensiveTeamId",
                table: "NflPlay");
        }
    }
}
