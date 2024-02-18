using Negosud.Class;
using Negosud.Dto;

namespace Negosud.Extensions
{
    public static class ProduitExtension
    {
        public static ProduitDto ToDto(this Produit produit)
        {
            return new ProduitDto
            {
                Id = produit.Id,
                Nom = produit.NomProduit,
                Prix = produit.PrixProduit,
                Nombre = produit.NbProduit,
                Domaine = produit.Domaine,
                Type = produit.Type,
                Quantite = produit.Quantite,
            };
        }
    }
}
