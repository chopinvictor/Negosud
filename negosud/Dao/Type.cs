using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Type
    {
        public int Id { get; set; }


        [StringLength(80)]
        public string NomType { get; set; } = string.Empty;

    }
}
