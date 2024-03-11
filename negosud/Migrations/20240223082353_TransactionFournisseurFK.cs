using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Negosud.Migrations
{
    /// <inheritdoc />
    public partial class TransactionFournisseurFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FournisseurId",
                table: "Commandes");

            migrationBuilder.AddColumn<int>(
                name: "FournisseurId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FournisseurId",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "FournisseurId",
                table: "Commandes",
                type: "int",
                nullable: true);
        }
    }
}
