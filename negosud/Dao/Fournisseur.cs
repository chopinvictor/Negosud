using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Fournisseur
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string NomFournisseur { get; set; } = string.Empty;

        public string AdresseFournisseur { get; set; } = string.Empty;

        [StringLength(5)]
        public int CodePostalFournisseur { get; set; }

        [StringLength(80)]
        public string PaysFournisseur { get; set; } = string.Empty;

        [StringLength(12)]
        public int TelephoneFournisseur { get; set; }

        [StringLength(80)]
        public string EmailFournisseur { get; set; } = string.Empty;

        public virtual List<Produit>? ListProduits { get; set; } = null!;

    }
}
