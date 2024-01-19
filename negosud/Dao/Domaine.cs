using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Domaine
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string nomDomaine { get; set; } = string.Empty;

        public string adresseDomaine { get; set; } = string.Empty;

        [StringLength(5)]
        public int codePostalDomaine { get; set; }

        [StringLength(80)]
        public string paysDomaine { get; set; } = string.Empty;
    }
}
