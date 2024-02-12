using Negosud.Class;
using NegosudWpf.Services;
using System.Collections.ObjectModel;

namespace NegosudWpf.ViewModels
{
    public class ClientsViewModel : BaseViewModel
    {
        #region Singleton
        private static ClientsViewModel instance = new ClientsViewModel();

        public static ClientsViewModel Instance { get => instance; }

        #endregion

        public Client Client { get; set; }

        public int ClientId { get; set; }

        public ObservableCollection<Client> ListeClients { get; set; }

        public ClientsViewModel()
        {
            GetAllClients();
        }

        public async void GetClient(int clientId)
        {
            Client = await HttpClientService.GetClient(clientId);
            ClientId = clientId;
            OnPropertyChanged(nameof(Client));
        }

        public async Task GetAllClients()
        {
            ListeClients = await HttpClientService.GetAllClients();
            OnPropertyChanged(nameof(ListeClients));
        }

        public async void CreateClient(Client client)
        {
            await HttpClientService.CreateClient(client);
        }

        public async void UpdateClient(Client client) 
        {
            await HttpClientService.UpdateClient(client);
        }

        public async void DeleteClient(int id)
        {
            await HttpClientService.DeleteClient(id);
        }
    }
}
