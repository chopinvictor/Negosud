using Negosud.Class;
using NegosudWpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views.Fournisseurs
{
    /// <summary>
    /// Logique d'interaction pour ucCreateFournisseur.xaml
    /// </summary>
    public partial class ucCreateFournisseur : UserControl
    {
        public ucCreateFournisseur()
        {
            InitializeComponent();
        }


        private void CreateFournisseurValidation_Click(object sender, RoutedEventArgs e)
        {
            var Fournisseur = new Fournisseur()
            {
                NomFournisseur = Nom.Text,
                AdresseFournisseur = Adresse.Text,
                CodePostalFournisseur = CP.Text,
                VilleFournisseur = Ville.Text,
                EmailFournisseur = Email.Text,
                PaysFournisseur = Pays.Text,
                TelephoneFournisseur = Tel.Text
            };

            FournisseursViewModel.Instance.CreateFournisseur(Fournisseur);
        }

        private void ReturnFournisseurList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerFournisseurList();
        }
    }
}
