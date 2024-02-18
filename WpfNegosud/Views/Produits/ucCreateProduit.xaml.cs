using Negosud.Class;
using NegosudWpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views.Clients
{
    /// <summary>
    /// Logique d'interaction pour ucCreateClient.xaml
    /// </summary>
    public partial class ucCreateProduit : UserControl
    {
        public ucCreateProduit()
        {
            InitializeComponent();
        }

        private void CreateClientValidation_Click(object sender, RoutedEventArgs e)
        {
            var temp = Prix.Text.Replace(".", ",");

            double prix;
            double.TryParse(temp, out prix);

            int nombre;
            int.TryParse(Nb.Text, out nombre);

            var produit = new Produit()
            {
                NomProduit = Nom.Text,
                PrixProduit = prix,
                NbProduit = nombre
            };
            ProduitsViewModel.Instance.CreateProduit(produit);
        }
    }
}
