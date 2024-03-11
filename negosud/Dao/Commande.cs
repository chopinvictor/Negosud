using System.ComponentModel.DataAnnotations.Schema;

namespace Negosud.Class
{
    public class Commande
    {
        public int Id { get; set; }

        public double? PrixTotal { get; set; }

        public bool EstEntreeSortie { get; set; }

        public DateTime DateCommande { get; set; }

        public int Remise { get; set; } // pourcentage ? exemple : 10 = 10% ?

        [ForeignKey(nameof(Client))]
        public int? ClientId { get; set; }

        public virtual List<Produit>? ListProduits { get; set; } = null!;
    }
}
