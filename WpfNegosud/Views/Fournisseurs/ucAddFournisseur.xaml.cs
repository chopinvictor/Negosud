using Negosud.Class;
using NegosudWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NegosudWpf.Views.Fournisseurs
{
    /// <summary>
    /// Logique d'interaction pour ucAddFournisseur.xaml
    /// </summary>
    public partial class ucAddFournisseur : UserControl
    {

        public Fournisseur Fournisseur = new Fournisseur();

        public int FournisseurId { get; set; }

        public ucAddFournisseur()
        {
            InitializeComponent();
        }
        private void UpdateFournisseurValidation_Click(object sender, RoutedEventArgs e)
        {
            var fournisseur = new Fournisseur()
            {
                Id = FournisseurId,
                NomFournisseur = Nom.Text,
                AdresseFournisseur = Adresse.Text,
                CodePostalFournisseur = CP.Text,
                VilleFournisseur = Ville.Text,
                EmailFournisseur = Email.Text,
                PaysFournisseur = Pays.Text,
                TelephoneFournisseur = Telephone.Text
            };
            FournisseursViewModel.Instance.UpdateFournisseur(fournisseur);
        }
        private void DeleteFournisseur_Click(object sender, RoutedEventArgs e)
        {
            FournisseursViewModel.Instance.DeleteFournisseur(FournisseurId);
        }

        private void MenuFournisseurs_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerFournisseurList();
        }

    }
}
