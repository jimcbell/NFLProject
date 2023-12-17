using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class removingteams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefenseTeam",
                table: "NflPlay");

            migrationBuilder.DropColumn(
                name: "OffenseTeam",
                table: "NflPlay");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DefenseTeam",
                table: "NflPlay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OffenseTeam",
                table: "NflPlay",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
