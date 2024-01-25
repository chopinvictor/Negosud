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

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Adresse { get; set; }

        public string CodePostal { get; set; }

        public string Pays { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }
    }
}
