using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class namechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayTypeId",
                table: "NflPlayType",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_NflPlayType_PlayTypeId",
                table: "NflPlayType",
                newName: "IX_NflPlayType_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NflPlayType",
                newName: "PlayTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_NflPlayType_Id",
                table: "NflPlayType",
                newName: "IX_NflPlayType_PlayTypeId");
        }
    }
}
