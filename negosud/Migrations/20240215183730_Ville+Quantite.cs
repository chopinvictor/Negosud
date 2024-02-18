using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Negosud.Migrations
{
    /// <inheritdoc />
    public partial class VilleQuantite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantite",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "Quantite",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "VilleFournisseur",
                table: "Fournisseurs");

            migrationBuilder.DropColumn(
                name: "VilleDomaine",
                table: "Domaines");
        }
    }
}
