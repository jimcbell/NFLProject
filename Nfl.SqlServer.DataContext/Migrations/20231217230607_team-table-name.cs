using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class teamtablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflTeams_DefensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflTeams_OffensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NflTeams",
                table: "NflTeams");

            migrationBuilder.RenameTable(
                name: "NflTeams",
                newName: "NflTeam");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NflTeam",
                table: "NflTeam",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflTeam_DefensiveTeamId",
                table: "NflPlay",
                column: "DefensiveTeamId",
                principalTable: "NflTeam",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflTeam_OffensiveTeamId",
                table: "NflPlay",
                column: "OffensiveTeamId",
                principalTable: "NflTeam",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflTeam_DefensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflTeam_OffensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NflTeam",
                table: "NflTeam");

            migrationBuilder.RenameTable(
                name: "NflTeam",
                newName: "NflTeams");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NflTeams",
                table: "NflTeams",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflTeams_DefensiveTeamId",
                table: "NflPlay",
                column: "DefensiveTeamId",
                principalTable: "NflTeams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflTeams_OffensiveTeamId",
                table: "NflPlay",
                column: "OffensiveTeamId",
                principalTable: "NflTeams",
                principalColumn: "Id");
        }
    }
}
