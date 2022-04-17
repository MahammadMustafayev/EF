using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class CreateBookWriter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookWriter_Book_BookId",
                table: "BookWriter");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWriter_Writers_WriterId",
                table: "BookWriter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookWriter",
                table: "BookWriter");

            migrationBuilder.RenameTable(
                name: "BookWriter",
                newName: "BookWriters");

            migrationBuilder.RenameIndex(
                name: "IX_BookWriter_WriterId",
                table: "BookWriters",
                newName: "IX_BookWriters_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_BookWriter_BookId",
                table: "BookWriters",
                newName: "IX_BookWriters_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookWriters",
                table: "BookWriters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookWriters_Book_BookId",
                table: "BookWriters",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookWriters_Writers_WriterId",
                table: "BookWriters",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookWriters_Book_BookId",
                table: "BookWriters");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWriters_Writers_WriterId",
                table: "BookWriters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookWriters",
                table: "BookWriters");

            migrationBuilder.RenameTable(
                name: "BookWriters",
                newName: "BookWriter");

            migrationBuilder.RenameIndex(
                name: "IX_BookWriters_WriterId",
                table: "BookWriter",
                newName: "IX_BookWriter_WriterId");

            migrationBuilder.RenameIndex(
                name: "IX_BookWriters_BookId",
                table: "BookWriter",
                newName: "IX_BookWriter_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookWriter",
                table: "BookWriter",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookWriter_Book_BookId",
                table: "BookWriter",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookWriter_Writers_WriterId",
                table: "BookWriter",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
