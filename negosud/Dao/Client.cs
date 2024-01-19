using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string nomClient { get; set; } = string.Empty;

        [StringLength(80)]
        public string prenomClient { get; set; } = string.Empty;

        public string adresseClient { get; set; } = string.Empty;


        [StringLength(5)]
        public int codePostalClient { get; set; }

        [StringLength(80)]
        public string paysClient { get; set; } = string.Empty;


        [StringLength(12)]
        public int telephoneClient { get; set; }


        [StringLength(80)]
        public string emailClient { get; set; } = string.Empty;


        // Transaction
        [ForeignKey(nameof(Transaction))]
        public int transactionID { get; set; }

        public virtual Transaction Transaction { get; set; } = null!;

    }
}
