using Negosud.Class;
using NegosudWpf.ViewModels;
using NegosudWpf.Windows;
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

            ClientDetailsPopup clientDetailsPopup = new ClientDetailsPopup();
            clientDetailsPopup.Show();
        }
    }
}
