using System.ComponentModel.DataAnnotations;

namespace Negosud.Class
{
    public class Fournisseur
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string NomFournisseur { get; set; } = string.Empty;

        public string AdresseFournisseur { get; set; } = string.Empty;

        public string CodePostalFournisseur { get; set; } = string.Empty;

        public string VilleFournisseur { get; set; } = string.Empty;

        [StringLength(80)]
        public string PaysFournisseur { get; set; } = string.Empty;

        public string TelephoneFournisseur { get; set; } = string.Empty;

        [StringLength(80)]
        public string EmailFournisseur { get; set; } = string.Empty;

        public virtual List<Historique>? ListHistorique { get; set; } = null!;

    }
}
