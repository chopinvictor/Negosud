using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Commande
    {
        public int Id { get; set; }

        public float PrixTotal { get; set; }

        public int Remise { get; set; } // pourcentage ? exemple : 10 = 10% ?

        [ForeignKey(nameof(Fournisseur))]
        public int? FournisseurId { get; set; }

        [ForeignKey(nameof(Client))]
        public int? ClientId { get; set; }

        public virtual List<Produit>? ListProduits { get; set; } = null!;

    }
}
