using Negosud.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Negosud.Class.Type;

namespace Negosud.Dto
{
    public class ProduitCommandeDto
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public double PrixUnitaire { get; set; }

        public int NombreCommande { get; set; }

        public double PrixTotal { get; set; }

        public int FournisseurId { get; set; }

        public Type? Type { get; set; }

        public Domaine? Domaine { get; set; }

        public List<Commande>? ListCommandes { get; set; }

        public List<Historique>? ListHistorique { get; set; }
    }
}
