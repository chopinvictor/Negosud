using Negosud.Class;
using Negosud.Dto;
using NegosudWpf.ViewModels;
using NegosudWpf.Windows;
using System.Windows;
using System.Windows.Controls;
using Type = Negosud.Class.Type;

namespace NegosudWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour ucClientsList.xaml
    /// </summary>
    public partial class ucProduitsList : UserControl
    {
        public ucProduitsList()
        {
            InitializeComponent();
        }

        private void ProduitDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerProduit(((ProduitDto)btn.DataContext).Id,
                                                  ((ProduitDto)btn.DataContext).Domaine.Id,
                                                  ((ProduitDto)btn.DataContext).Type.Id);

            //ClientDetailsPopup clientDetailsPopup = new ClientDetailsPopup();
            //clientDetailsPopup.Show();
        }

        private void ProduitCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateProduit();
        }
    }
}
