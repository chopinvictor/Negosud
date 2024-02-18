using NegosudWpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views.Shared
{
    /// <summary>
    /// Logique d'interaction pour NavBar.xaml
    /// </summary>
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
        }
        private void MenuAccueil_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerAccueil();
        }
        private void MenuClients_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerClientList();
        }

        private void MenuProduits_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerProduitList();
        }

        private void MenuFournisseurs_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerFournisseurList();
        }
        private void MenuDomaines_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerDomaineList();
        }

    }
}
