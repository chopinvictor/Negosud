using System.ComponentModel.DataAnnotations.Schema;

namespace Negosud.Class
{
    public class Transaction
    {
        public int Id { get; set; }

        public int NbProduit { get; set; }

        public string? Description { get; set; } = string.Empty;

        public int Remise { get; set; } // pourcentage ? exemple : 10 = 10% ?

        [ForeignKey(nameof(Commande))]
        public int CommandeId { get; set; }

        public virtual Commande Commande { get; set; } = null!;

        [ForeignKey(nameof(Produit))]
        public int ProduitId { get; set; }

        public virtual Produit Produit { get; set; } = null!;
    }
}
