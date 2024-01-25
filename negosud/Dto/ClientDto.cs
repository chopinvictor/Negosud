using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }

        public string NomClient { get; set; }

        public string PrenomClient { get; set; }

        public string AdresseClient { get; set; }

        public string CodePostalClient { get; set; }

        public string PaysClient { get; set; }

        public string TelephoneClient { get; set; }

        public string EmailClient { get; set; }
    }
}
