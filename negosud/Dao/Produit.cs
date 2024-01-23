using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negosud.Class
{
    public class Produit
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string NomProduit { get; set; } = string.Empty;

        public int NbProduit { get; set; }

        public double PrixProduit { get; set; }

        // Type
        [ForeignKey(nameof(Type))]
        public int TypeID { get; set; }

        public virtual Type Type { get; set; } = null!;

        // Domaine
        [ForeignKey(nameof(Domaine))]
        public int DomaineID { get; set; }

        public virtual Domaine Domaine { get; set; } = null!;

        // Commandes
        public virtual List<Commande>? ListCommandes { get; set; } = null!;

        // Fournisseurs
        public virtual List<Historique>? ListHistorique { get; set; } = null!;
    }
}
