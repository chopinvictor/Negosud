using Negosud.Class;
using NegosudWpf.ViewModels;
using NegosudWpf.Windows;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour ucClientsList.xaml
    /// </summary>
    public partial class ucClientsList : UserControl
    {
        public ucClientsList()
        {
            InitializeComponent();
        }

        private void ClientDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerClient(((Client)btn.DataContext).Id);

            //ClientDetailsPopup clientDetailsPopup = new ClientDetailsPopup();
            //clientDetailsPopup.Show();
        }

        private void ClientCreate_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.CreateClient();
        }

        private void ReturnClientList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerClientList();
        }
    }
}
