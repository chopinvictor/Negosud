using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Transaction
    {
        public int Id { get; set; }

        public int nbrProduit{ get; set; }

        public bool entreesortie { get; set; }

        public string description { get; set; } = string.Empty;

        public int remise { get; set; } // pourcentage ? exemple : 10 = 10% ?


        public ICollection<Produit> Produits { get; set; } = null!;
    }
}
