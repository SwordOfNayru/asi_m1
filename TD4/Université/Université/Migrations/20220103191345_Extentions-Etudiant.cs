using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Université.Migrations
{
    public partial class ExtentionsEtudiant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Etudiant",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroEtudiant",
                table: "Etudiant",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Etudiant",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormationSuivieID",
                table: "Etudiant",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Formation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Intitule = table.Column<string>(type: "text", nullable: true),
                    AnneDiplome = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formation", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etudiant_FormationSuivieID",
                table: "Etudiant",
                column: "FormationSuivieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Etudiant_Formation_FormationSuivieID",
                table: "Etudiant",
                column: "FormationSuivieID",
                principalTable: "Formation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etudiant_Formation_FormationSuivieID",
                table: "Etudiant");

            migrationBuilder.DropTable(
                name: "Formation");

            migrationBuilder.DropIndex(
                name: "IX_Etudiant_FormationSuivieID",
                table: "Etudiant");

            migrationBuilder.DropColumn(
                name: "FormationSuivieID",
                table: "Etudiant");

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Etudiant",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroEtudiant",
                table: "Etudiant",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Etudiant",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
