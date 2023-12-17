using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class passtyperelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayType",
                table: "NflPlayType",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "NflPassTypeId",
                table: "NflPlay",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NflPassType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NflPassType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NflPlay_NflPassTypeId",
                table: "NflPlay",
                column: "NflPassTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NflPassType_Id",
                table: "NflPassType",
                column: "Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflPassType_NflPassTypeId",
                table: "NflPlay",
                column: "NflPassTypeId",
                principalTable: "NflPassType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflPassType_NflPassTypeId",
                table: "NflPlay");

            migrationBuilder.DropTable(
                name: "NflPassType");

            migrationBuilder.DropIndex(
                name: "IX_NflPlay_NflPassTypeId",
                table: "NflPlay");

            migrationBuilder.DropColumn(
                name: "NflPassTypeId",
                table: "NflPlay");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "NflPlayType",
                newName: "PlayType");
        }
    }
}
