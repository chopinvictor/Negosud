using System.ComponentModel.DataAnnotations;

namespace Negosud.Class
{
    public class Domaine
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string NomDomaine { get; set; } = string.Empty;

        public string AdresseDomaine { get; set; } = string.Empty;

        public string VilleDomaine { get; set; } = string.Empty;

        public string CodePostalDomaine { get; set; } = string.Empty;

        [StringLength(80)]
        public string PaysDomaine { get; set; } = string.Empty;

    }
}
