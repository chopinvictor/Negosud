using NegosudWpf.ViewModels;
using NegosudWpf.Views;
using System.Windows;

namespace WpfNegosud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuClients_Click(object sender, RoutedEventArgs e)
        {
            var uc = new ClientControl1();
            uc.DataContext = new ClientsViewModel();
            MainCC.Content = uc;
        }

        private void MenuProduits_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}