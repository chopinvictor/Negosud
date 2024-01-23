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
        public string NomDomaine { get; set; } = string.Empty;

        public string AdresseDomaine { get; set; } = string.Empty;

        [StringLength(5)]
        public int CodePostalDomaine { get; set; }

        [StringLength(80)]
        public string PaysDomaine { get; set; } = string.Empty;
    }
}
