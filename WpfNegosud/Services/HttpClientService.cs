using Negosud.Class;
using Negosud.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NegosudWpf.Services
{
    public static class HttpClientService
    {
        private const string baseAddress = "https://localhost:7226/";
        private static HttpClient? client = null;

        private static HttpClient Client
        {
            get
            {
                if (client == null)
                    client = new() { BaseAddress = new Uri(baseAddress) };
                return client;
            }
        }

        public static async Task<ClientDto> GetClient(int clientId)
        {
            string route = $"clients/{clientId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ClientDto>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }
    }
}
