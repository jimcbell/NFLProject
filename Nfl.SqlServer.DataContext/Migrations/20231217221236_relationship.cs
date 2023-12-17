using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NflPlayTypePlayTypeId",
                table: "NflPlay",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NflPlay_NflPlayTypePlayTypeId",
                table: "NflPlay",
                column: "NflPlayTypePlayTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypePlayTypeId",
                table: "NflPlay",
                column: "NflPlayTypePlayTypeId",
                principalTable: "NflPlayType",
                principalColumn: "PlayTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypePlayTypeId",
                table: "NflPlay");

            migrationBuilder.DropIndex(
                name: "IX_NflPlay_NflPlayTypePlayTypeId",
                table: "NflPlay");

            migrationBuilder.DropColumn(
                name: "NflPlayTypePlayTypeId",
                table: "NflPlay");
        }
    }
}
