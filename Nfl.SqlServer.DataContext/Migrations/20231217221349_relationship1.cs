using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class relationship1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "NflPlayTypeId",
                table: "NflPlay",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NflPlay_NflPlayTypeId",
                table: "NflPlay",
                column: "NflPlayTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypeId",
                table: "NflPlay",
                column: "NflPlayTypeId",
                principalTable: "NflPlayType",
                principalColumn: "PlayTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypeId",
                table: "NflPlay");

            migrationBuilder.DropIndex(
                name: "IX_NflPlay_NflPlayTypeId",
                table: "NflPlay");

            migrationBuilder.DropColumn(
                name: "NflPlayTypeId",
                table: "NflPlay");

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
    }
}
