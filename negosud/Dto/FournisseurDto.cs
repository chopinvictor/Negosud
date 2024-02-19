using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Dto
{
    public class FournisseurDto
    {
        public int Id { get; set; }

        public string NomFournisseur { get; set; } = string.Empty;

        public string AdresseFournisseur { get; set; } = string.Empty;

        public string CodePostalFournisseur { get; set; } = string.Empty;

        public string VilleFournisseur { get; set; } = string.Empty;

        public double? PrixProduit { get; set; }
    }
}
