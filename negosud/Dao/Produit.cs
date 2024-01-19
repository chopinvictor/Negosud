using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negosud.Class
{
    public class Produit
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string nomProduit { get; set; } = string.Empty;



        // Type
        [ForeignKey(nameof(Type))]
        public int typeID { get; set; }

        public virtual Type Type { get; set; } = null!;



        // Domaine
        [ForeignKey(nameof(Domaine))]
        public int domaineID { get; set; }

        public virtual Domaine Domaine { get; set; } = null!;

    }
}
