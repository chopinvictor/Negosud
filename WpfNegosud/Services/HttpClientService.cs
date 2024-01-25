using Negosud.Class;
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

        public static async Task<ClientDto>
    }
}
