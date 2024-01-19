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
        public string nomFournisseur { get; set; } = string.Empty;

        public string adresseFournisseur { get; set; } = string.Empty;

        [StringLength(5)]
        public int codePostalFournisseur { get; set; }

        [StringLength(80)]
        public string paysFournisseur { get; set; } = string.Empty;

        [StringLength(12)]
        public int telephoneFournisseur { get; set; }

        [StringLength(80)]
        public string emailFournisseur { get; set; } = string.Empty;



        // Transaction
        [ForeignKey(nameof(Transaction))]
        public int transactionID { get; set; }

        public virtual Transaction Transaction { get; set; } = null!;
    }
}
