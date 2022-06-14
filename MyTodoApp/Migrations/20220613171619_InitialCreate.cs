using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTodoApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Título = table.Column<string>(type: "TEXT", nullable: false),
                    Concluído = table.Column<bool>(type: "INTEGER", nullable: false),
                    Criação = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Atualização = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
