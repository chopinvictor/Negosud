using Negosud.Class;
using Negosud.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegosudWpf.ViewModels
{
    public class ProduitCommandeViewModel : BaseViewModel
    {
        public ProduitCommandeDto Produit { get; set; }

        public double PrixUnitaire
        {
            get { return Produit.PrixUnitaire; }
            set 
            {
                Produit.PrixUnitaire = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrixTotal));
            }
        }

        public int NombreCommande
        {
            get { return Produit.NombreCommande; }
            set
            {
                Produit.NombreCommande = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrixTotal));
            }
        }

        public double PrixTotal
        {
            get { return Produit.PrixUnitaire * Produit.NombreCommande; }
        }


        public ProduitCommandeViewModel(ProduitCommandeDto produit)
        {
            Produit = produit;
        }
    }
}
