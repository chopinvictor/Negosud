using Negosud.Class;
using NegosudWpf.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace NegosudWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour ClientControl1.xaml
    /// </summary>
    public partial class ucClientControl : UserControl
    {
        public Client Client = new Client();

        public int ClientId { get; set; }

        public ucClientControl()
        {
            InitializeComponent();
        }
        private void UpdateClientValidation_Click(object sender, RoutedEventArgs e)
        {
            var client = new Client()
            {
                Id = ClientId,
                NomClient = Nom.Text,
                PrenomClient = Prenom.Text,
                AdresseClient = Adresse.Text,
                CodePostalClient = CP.Text,
                VilleClient = Ville.Text,
                EmailClient = Email.Text,
                PaysClient = Pays.Text,
                TelephoneClient = Tel.Text
            };
            ClientsViewModel.Instance.UpdateClient(client);
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            ClientsViewModel.Instance.DeleteClient(ClientId);
        }

        private void ReturnClientList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerClientList();
        }
    }
}
