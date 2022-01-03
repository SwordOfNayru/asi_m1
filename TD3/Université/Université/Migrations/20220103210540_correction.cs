using Microsoft.EntityFrameworkCore.Migrations;

namespace Université.Migrations
{
    public partial class correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enseigner_UE_MyPropertyID",
                table: "Enseigner");

            migrationBuilder.DropIndex(
                name: "IX_Enseigner_MyPropertyID",
                table: "Enseigner");

            migrationBuilder.DropColumn(
                name: "MyPropertyID",
                table: "Enseigner");

            migrationBuilder.CreateIndex(
                name: "IX_Enseigner_LUEID",
                table: "Enseigner",
                column: "LUEID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enseigner_UE_LUEID",
                table: "Enseigner",
                column: "LUEID",
                principalTable: "UE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enseigner_UE_LUEID",
                table: "Enseigner");

            migrationBuilder.DropIndex(
                name: "IX_Enseigner_LUEID",
                table: "Enseigner");

            migrationBuilder.AddColumn<int>(
                name: "MyPropertyID",
                table: "Enseigner",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enseigner_MyPropertyID",
                table: "Enseigner",
                column: "MyPropertyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enseigner_UE_MyPropertyID",
                table: "Enseigner",
                column: "MyPropertyID",
                principalTable: "UE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
