using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Université.Migrations
{
    public partial class AddNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etudier",
                columns: table => new
                {
                    LEtudiantID = table.Column<int>(type: "integer", nullable: false),
                    LUEID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudier", x => new { x.LEtudiantID, x.LUEID });
                    table.ForeignKey(
                        name: "FK_Etudier_Etudiant_LEtudiantID",
                        column: x => x.LEtudiantID,
                        principalTable: "Etudiant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Etudier_UE_LUEID",
                        column: x => x.LUEID,
                        principalTable: "UE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valeur = table.Column<float>(type: "real", nullable: false),
                    RelationEtudiantLEtudiantID = table.Column<int>(type: "integer", nullable: true),
                    RelationEtudiantLUEID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_Etudier_RelationEtudiantLEtudiantID_RelationEtudiantLU~",
                        columns: x => new { x.RelationEtudiantLEtudiantID, x.RelationEtudiantLUEID },
                        principalTable: "Etudier",
                        principalColumns: new[] { "LEtudiantID", "LUEID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etudier_LUEID",
                table: "Etudier",
                column: "LUEID");

            migrationBuilder.CreateIndex(
                name: "IX_Note_RelationEtudiantLEtudiantID_RelationEtudiantLUEID",
                table: "Note",
                columns: new[] { "RelationEtudiantLEtudiantID", "RelationEtudiantLUEID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "Etudier");
        }
    }
}
