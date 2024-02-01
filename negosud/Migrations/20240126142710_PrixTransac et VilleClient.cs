using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Negosud.Migrations
{
    /// <inheritdoc />
    public partial class PrixTransacetVilleClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historique_Fournisseurs_FournisseurId",
                table: "Historique");

            migrationBuilder.DropForeignKey(
                name: "FK_Historique_Produits_ProduitId",
                table: "Historique");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historique",
                table: "Historique");

            migrationBuilder.RenameTable(
                name: "Historique",
                newName: "Historiques");

            migrationBuilder.RenameIndex(
                name: "IX_Historique_ProduitId",
                table: "Historiques",
                newName: "IX_Historiques_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Historique_FournisseurId",
                table: "Historiques",
                newName: "IX_Historiques_FournisseurId");

            migrationBuilder.AddColumn<double>(
                name: "Prix",
                table: "Transactions",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "VilleClient",
                table: "Clients",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historiques",
                table: "Historiques",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historiques_Fournisseurs_FournisseurId",
                table: "Historiques",
                column: "FournisseurId",
                principalTable: "Fournisseurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historiques_Produits_ProduitId",
                table: "Historiques",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historiques_Fournisseurs_FournisseurId",
                table: "Historiques");

            migrationBuilder.DropForeignKey(
                name: "FK_Historiques_Produits_ProduitId",
                table: "Historiques");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Historiques",
                table: "Historiques");

            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "VilleClient",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Historiques",
                newName: "Historique");

            migrationBuilder.RenameIndex(
                name: "IX_Historiques_ProduitId",
                table: "Historique",
                newName: "IX_Historique_ProduitId");

            migrationBuilder.RenameIndex(
                name: "IX_Historiques_FournisseurId",
                table: "Historique",
                newName: "IX_Historique_FournisseurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Historique",
                table: "Historique",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Historique_Fournisseurs_FournisseurId",
                table: "Historique",
                column: "FournisseurId",
                principalTable: "Fournisseurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Historique_Produits_ProduitId",
                table: "Historique",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
