using Negosud.Class;
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

        public Fournisseur? Fournisseur { get; set; }

        public Type? Type { get; set; }

        public Domaine? Domaine { get; set; }

        public List<Commande>? ListCommandes { get; set; }

        public List<Historique>? ListHistorique { get; set; }
    }
}
