using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nfl.SqlServer.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class nullablefk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypeId",
                table: "NflPlay");

            migrationBuilder.AlterColumn<int>(
                name: "NflPlayTypeId",
                table: "NflPlay",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypeId",
                table: "NflPlay",
                column: "NflPlayTypeId",
                principalTable: "NflPlayType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypeId",
                table: "NflPlay");

            migrationBuilder.AlterColumn<int>(
                name: "NflPlayTypeId",
                table: "NflPlay",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NflPlay_NflPlayType_NflPlayTypeId",
                table: "NflPlay",
                column: "NflPlayTypeId",
                principalTable: "NflPlayType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
