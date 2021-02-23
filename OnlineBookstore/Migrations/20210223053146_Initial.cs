﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookstore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    AuthorFirstName = table.Column<string>(nullable: true),
                    AuthorLastName = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Classification = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Pages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
