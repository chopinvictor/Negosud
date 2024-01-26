using Negosud.Class;
using NegosudWpf.Services;
using System.Collections.ObjectModel;

namespace NegosudWpf.ViewModels
{
    public class ClientsViewModel : BaseViewModel
    {
        public Client Client { get; set; }

        public ObservableCollection<Client> ListeClients { get; set; }

        public ClientsViewModel()
        {
            GetClient(1);
            test();
        }

        public async void GetClient(int clientId)
        {
            Client = await HttpClientService.GetClient(clientId);
            OnPropertyChanged(nameof(Client));
        }

        public async Task test()
        {
            ListeClients = await HttpClientService.GetAllClients();
            OnPropertyChanged(nameof(ListeClients));
        }
    }
}
