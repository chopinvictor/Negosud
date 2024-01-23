using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negosud.Class
{
    public class Historique
    {
        public int Id { get; set; }

        public double PrixAchat { get; set; }
        
        public DateTime DateD { get; set; }

        public DateTime? DateF { get; set; }

        [ForeignKey(nameof(Produit))]
        public int ProduitId { get; set; }

        [ForeignKey(nameof(Fournisseur))]
        public int FournisseurId { get; set; }
    }
}
