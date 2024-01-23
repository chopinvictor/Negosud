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
        public string NomClient { get; set; } = string.Empty;

        [StringLength(80)]
        public string PrenomClient { get; set; } = string.Empty;

        public string AdresseClient { get; set; } = string.Empty;


        [StringLength(5)]
        public int CodePostalClient { get; set; }

        [StringLength(80)]
        public string PaysClient { get; set; } = string.Empty;


        [StringLength(12)]
        public int TelephoneClient { get; set; }


        [StringLength(80)]
        public string EmailClient { get; set; } = string.Empty;
    }
}
