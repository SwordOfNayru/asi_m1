using Microsoft.EntityFrameworkCore.Migrations;

namespace Université.Migrations
{
    public partial class AjoutNumEtudiant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroEtudiant",
                table: "Etudiant",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroEtudiant",
                table: "Etudiant");
        }
    }
}
