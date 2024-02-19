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

namespace NegosudWpf.Views.Clients
{
    /// <summary>
    /// Logique d'interaction pour ucCreateClient.xaml
    /// </summary>
    public partial class ucCreateClient : UserControl
    {
        public ucCreateClient()
        {
            InitializeComponent();
        }

        private void CreateClientValidation_Click(object sender, RoutedEventArgs e)
        {
            var client = new Client()
            {
                NomClient = Nom.Text,
                PrenomClient = Prenom.Text,
                AdresseClient = Adresse.Text,
                CodePostalClient = CP.Text,
                VilleClient = Ville.Text,
                EmailClient = Email.Text,
                PaysClient = Pays.Text,
                TelephoneClient = Tel.Text
            };

            ClientsViewModel.Instance.CreateClient(client);
        }

        private void MenuClients_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerClientList();
        }
    }
}
