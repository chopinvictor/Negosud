using Negosud.Class;
using NegosudWpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views.Fournisseurs
{
    /// <summary>
    /// Logique d'interaction pour ucFournisseurList.xaml
    /// </summary>
    public partial class ucFournisseursList : UserControl
    {
        public ucFournisseursList()
        {
            InitializeComponent();
        }

        private void FournisseurCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateFournisseur();
        }

        private void FournisseurDetails_click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerFournisseur(((Fournisseur)btn.DataContext).Id);
        }

        private void ReturnFournisseurList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerFournisseurList();
        }

    }
}
