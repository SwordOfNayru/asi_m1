using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Université.Migrations
{
    public partial class AddManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enseignant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nom = table.Column<string>(type: "text", nullable: true),
                    Prenom = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseignant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Enseigner",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LenseignantID = table.Column<int>(type: "integer", nullable: false),
                    LUEID = table.Column<int>(type: "integer", nullable: false),
                    MyPropertyID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseigner", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Enseigner_Enseignant_LenseignantID",
                        column: x => x.LenseignantID,
                        principalTable: "Enseignant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enseigner_UE_MyPropertyID",
                        column: x => x.MyPropertyID,
                        principalTable: "UE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enseigner_LenseignantID",
                table: "Enseigner",
                column: "LenseignantID");

            migrationBuilder.CreateIndex(
                name: "IX_Enseigner_MyPropertyID",
                table: "Enseigner",
                column: "MyPropertyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enseigner");

            migrationBuilder.DropTable(
                name: "Enseignant");
        }
    }
}
