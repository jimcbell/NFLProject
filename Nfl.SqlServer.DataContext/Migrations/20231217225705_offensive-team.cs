using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class offensiveteam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassType",
                table: "NflPlay");

            migrationBuilder.AddColumn<int>(
                name: "OffensiveTeamId",
                table: "NflPlay",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NflTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NflTeams", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NflPlay_OffensiveTeamId",
                table: "NflPlay",
                column: "OffensiveTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflTeams_OffensiveTeamId",
                table: "NflPlay",
                column: "OffensiveTeamId",
                principalTable: "NflTeams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflTeams_OffensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropTable(
                name: "NflTeams");

            migrationBuilder.DropIndex(
                name: "IX_NflPlay_OffensiveTeamId",
                table: "NflPlay");

            migrationBuilder.DropColumn(
                name: "OffensiveTeamId",
                table: "NflPlay");

            migrationBuilder.AddColumn<string>(
                name: "PassType",
                table: "NflPlay",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
