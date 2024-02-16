using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Negosud.Migrations
{
    /// <inheritdoc />
    public partial class MAJVille : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VilleFournisseur",
                table: "Fournisseurs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "VilleDomaine",
                table: "Domaines",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VilleFournisseur",
                table: "Fournisseurs");

            migrationBuilder.DropColumn(
                name: "VilleDomaine",
                table: "Domaines");
        }
    }
}
