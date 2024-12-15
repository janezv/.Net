using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class RelacijaVC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_stocks_StockId",
                table: "comments");

            migrationBuilder.AlterColumn<int>(
                name: "StockId",
                table: "comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_stocks_StockId",
                table: "comments",
                column: "StockId",
                principalTable: "stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_stocks_StockId",
                table: "comments");

            migrationBuilder.AlterColumn<int>(
                name: "StockId",
                table: "comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_stocks_StockId",
                table: "comments",
                column: "StockId",
                principalTable: "stocks",
                principalColumn: "Id");
        }
    }
}
