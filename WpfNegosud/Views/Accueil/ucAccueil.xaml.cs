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

namespace NegosudWpf.Views.Accueil
{
    /// <summary>
    /// Logique d'interaction pour ucAccueil.xaml
    /// </summary>
    public partial class ucAccueil : UserControl
    {
        public ucAccueil()
        {
            InitializeComponent();
        }


        private void MenuFournisseurs_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerFournisseurList();
        }
        private void MenuClients_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerClientList();

        }

        private void MenuVentes_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerCreateVente();
        }

        private void MenuProduits_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerProduitList();
        }
    }
}
