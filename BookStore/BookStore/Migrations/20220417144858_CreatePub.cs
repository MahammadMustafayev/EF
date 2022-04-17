using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class CreatePub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Pubslishing_PubslishingId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Pubslishing_Pubslishing_PubslishingId",
                table: "Pubslishing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pubslishing",
                table: "Pubslishing");

            migrationBuilder.RenameTable(
                name: "Pubslishing",
                newName: "Pubslishings");

            migrationBuilder.RenameIndex(
                name: "IX_Pubslishing_PubslishingId",
                table: "Pubslishings",
                newName: "IX_Pubslishings_PubslishingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pubslishings",
                table: "Pubslishings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Pubslishings_PubslishingId",
                table: "Book",
                column: "PubslishingId",
                principalTable: "Pubslishings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pubslishings_Pubslishings_PubslishingId",
                table: "Pubslishings",
                column: "PubslishingId",
                principalTable: "Pubslishings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Pubslishings_PubslishingId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Pubslishings_Pubslishings_PubslishingId",
                table: "Pubslishings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pubslishings",
                table: "Pubslishings");

            migrationBuilder.RenameTable(
                name: "Pubslishings",
                newName: "Pubslishing");

            migrationBuilder.RenameIndex(
                name: "IX_Pubslishings_PubslishingId",
                table: "Pubslishing",
                newName: "IX_Pubslishing_PubslishingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pubslishing",
                table: "Pubslishing",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Pubslishing_PubslishingId",
                table: "Book",
                column: "PubslishingId",
                principalTable: "Pubslishing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pubslishing_Pubslishing_PubslishingId",
                table: "Pubslishing",
                column: "PubslishingId",
                principalTable: "Pubslishing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
