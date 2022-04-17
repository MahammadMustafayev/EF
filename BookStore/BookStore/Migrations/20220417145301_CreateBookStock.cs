using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class CreateBookStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Pages_PageId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Pubslishings_PubslishingId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_Book_BookId",
                table: "BookGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWriters_Book_BookId",
                table: "BookWriters");

            migrationBuilder.DropForeignKey(
                name: "FK_Stock_Book_BookId",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stock",
                table: "Stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Stock",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Stock_BookId",
                table: "Stocks",
                newName: "IX_Stocks_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PubslishingId",
                table: "Books",
                newName: "IX_Books_PubslishingId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_PageId",
                table: "Books",
                newName: "IX_Books_PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Books_BookId",
                table: "BookGenres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Pages_PageId",
                table: "Books",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Pubslishings_PubslishingId",
                table: "Books",
                column: "PubslishingId",
                principalTable: "Pubslishings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookWriters_Books_BookId",
                table: "BookWriters",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Books_BookId",
                table: "Stocks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGenres_Books_BookId",
                table: "BookGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Pages_PageId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Pubslishings_PubslishingId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWriters_Books_BookId",
                table: "BookWriters");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Books_BookId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "Stock");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_BookId",
                table: "Stock",
                newName: "IX_Stock_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PubslishingId",
                table: "Book",
                newName: "IX_Book_PubslishingId");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PageId",
                table: "Book",
                newName: "IX_Book_PageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stock",
                table: "Stock",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Pages_PageId",
                table: "Book",
                column: "PageId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Pubslishings_PubslishingId",
                table: "Book",
                column: "PubslishingId",
                principalTable: "Pubslishings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Book_BookId",
                table: "BookGenres",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookWriters_Book_BookId",
                table: "BookWriters",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stock_Book_BookId",
                table: "Stock",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
