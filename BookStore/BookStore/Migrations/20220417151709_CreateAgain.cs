using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class CreateAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pubslishings_Pubslishings_PubslishingId",
                table: "Pubslishings");

            migrationBuilder.DropIndex(
                name: "IX_Pubslishings_PubslishingId",
                table: "Pubslishings");

            migrationBuilder.DropColumn(
                name: "PubslishingId",
                table: "Pubslishings");

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_StockId",
                table: "Books",
                column: "StockId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Stocks_StockId",
                table: "Books",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Stocks_StockId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_StockId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "PubslishingId",
                table: "Pubslishings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pubslishings_PubslishingId",
                table: "Pubslishings",
                column: "PubslishingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pubslishings_Pubslishings_PubslishingId",
                table: "Pubslishings",
                column: "PubslishingId",
                principalTable: "Pubslishings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
