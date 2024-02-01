using System.ComponentModel.DataAnnotations;

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

        public string VilleClient { get; set; } = string.Empty;

        [StringLength(5)]
        public string CodePostalClient { get; set; } = string.Empty;

        [StringLength(80)]
        public string PaysClient { get; set; } = string.Empty;

        public string TelephoneClient { get; set; } = string.Empty;

        [StringLength(80)]
        public string EmailClient { get; set; } = string.Empty;
    }
}
