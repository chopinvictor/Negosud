using Negosud.Dto;
using NegosudWpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegosudWpf.ViewModels
{
    public class ClientsViewModel : BaseViewModel
    {
        public ClientDto Client { get; set; }
        
        public List<ClientDto> Clients { get; set; }

        public async void GetClient(int clientId)
        {
            Client = await HttpClientService.GetClient(clientId);
        }
    }
}
