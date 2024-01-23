using System.ComponentModel.DataAnnotations;

namespace Negosud.Class
{
    public class Type
    {
        public int Id { get; set; }


        [StringLength(80)]
        public string NomType { get; set; } = string.Empty;
    }
}
