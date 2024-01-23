using System.ComponentModel.DataAnnotations;

namespace Negosud.Class
{
    public class Utilisateur
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string NomUtilisateur { get; set; } = string.Empty;

        [StringLength(80)]
        public string MotDePasse { get; set; } = string.Empty;

        [StringLength(80)]
        public bool Admin { get; set; }
    }
}
