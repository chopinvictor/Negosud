using System.ComponentModel.DataAnnotations;

namespace Negosud.Class
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string nomUser { get; set; } = string.Empty;

        [StringLength(80)]
        public string password { get; set; } = string.Empty;

        [StringLength(80)]
        public bool admin { get; set; }
    }
}
