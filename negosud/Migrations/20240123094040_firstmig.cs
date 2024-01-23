using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Negosud.Migrations
{
    /// <inheritdoc />
    public partial class firstmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandeProduit_Commande_ListCommandesId",
                table: "CommandeProduit");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Commande_CommandeId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commande",
                table: "Commande");

            migrationBuilder.RenameTable(
                name: "Commande",
                newName: "Commandes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commandes",
                table: "Commandes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandeProduit_Commandes_ListCommandesId",
                table: "CommandeProduit",
                column: "ListCommandesId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Commandes_CommandeId",
                table: "Transaction",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommandeProduit_Commandes_ListCommandesId",
                table: "CommandeProduit");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Commandes_CommandeId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Commandes",
                table: "Commandes");

            migrationBuilder.RenameTable(
                name: "Commandes",
                newName: "Commande");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commande",
                table: "Commande",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommandeProduit_Commande_ListCommandesId",
                table: "CommandeProduit",
                column: "ListCommandesId",
                principalTable: "Commande",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Commande_CommandeId",
                table: "Transaction",
                column: "CommandeId",
                principalTable: "Commande",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
