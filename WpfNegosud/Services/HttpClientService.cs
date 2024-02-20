using Negosud.Class;
using Negosud.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Type = Negosud.Class.Type;

namespace NegosudWpf.Services
{
    public static class HttpClientService
    {
        private const string baseAddress = "https://localhost:7226/api/";
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

        public static async Task<bool> Login(string email, string pwd)
        {
            string route = "login?useCookies=true&useSessionCookies=true";
            var jsonString = JsonConvert.SerializeObject(new LoginUser
            {
                Email = email,
                Password = pwd
            });

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(route, httpContent);

            var cookies = cookieContainer.GetCookies(new Uri(baseAddress));
            Debug.WriteLine(cookies);

            return response.IsSuccessStatusCode ? true :
                throw new Exception(response.ReasonPhrase);
        }

        #region Clients

        public static async Task<Client> GetClient(int clientId)
        {
            string route = $"Clients/{clientId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Client>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Client>> GetAllClients()
        {
            string route = $"Clients";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Client>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateClient(Client client)
        {
            string route = $"Clients";
            string json = JsonConvert.SerializeObject(client);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task DeleteClient(int id)
        {
            string route = $"Clients/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateClient(Client client)
        {
            string route = $"Clients/{client.Id}";

            string json = JsonConvert.SerializeObject(client);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        #endregion

        #region Produits

        public static async Task<ProduitDto> GetProduit(int produitId)
        {
            string route = $"Produits/{produitId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProduitDto>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<ProduitDto>> GetAllProduits()
        {
            string route = $"Produits";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<ProduitDto>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateProduit(Produit produit)
        {
            string route = $"Produits";
            string json = JsonConvert.SerializeObject(produit);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task DeleteProduit(int id)
        {
            string route = $"Produits/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateProduit(Produit produit)
        {
            string route = $"Produits/{produit.Id}";

            string json = JsonConvert.SerializeObject(produit);
            var buffer = Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }
        #endregion

        #region Domaines

        public static async Task<Domaine> GetDomaine(int domaineId)
        {
            string route = $"Domaines/{domaineId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Domaine>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Domaine>> GetAllDomaines()
        {
            string route = $"Domaines";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Domaine>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateDomaine(Domaine domaine)
        {
            string route = $"Domaines";
            string json = JsonConvert.SerializeObject(domaine);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task DeleteDomaine(int id)
        {
            string route = $"Domaines/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateDomaine(Domaine domaine)
        {
            string route = $"Domaines/{domaine.Id}";

            string json = JsonConvert.SerializeObject(domaine);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }

        #endregion

        #region Types
        public static async Task<ObservableCollection<Type>> GetAllTypes()
        {
            string route = $"Types";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Type>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }
        #endregion

        #region Fournisseurs

        public static async Task<Fournisseur> GetFournisseur(int fournisseurId)
        {
            string route = $"Fournisseurs/{fournisseurId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Fournisseur>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Fournisseur>> GetAllFournisseurs()
        {
            string route = $"Fournisseurs";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Fournisseur>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateFournisseur(Fournisseur fournisseur)
        {
            string route = $"Fournisseurs";
            string json = JsonConvert.SerializeObject(fournisseur);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateFournisseur(Fournisseur fournisseur)
        {
            string route = $"Fournisseurs/{fournisseur.Id}";

            string json = JsonConvert.SerializeObject(fournisseur);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }

        public static async Task DeleteFournisseur(int id)
        {
            string route = $"Fournisseurs/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        #endregion

        #region Commandes

        public static async Task<Commande> GetCommande(int commandeId)
        {
            string route = $"Commandes/{commandeId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Commande>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Commande>> GetAllCommandes()
        {
            string route = $"Commandes";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Commande>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<Commande> CreateCommande(Commande commande)
        {
            string route = $"Commandes";
            string json = JsonConvert.SerializeObject(commande);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await Client.PostAsync(route, byteContent);


            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
            else
            {
                var res = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Commande>(res) ?? throw new FormatException("Erreur lors de la récupération de la commande");
            }
        }

        public static async Task DeleteCommande(int id)
        {
            string route = $"Commandes/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateCommande(Commande commande)
        {
            string route = $"Commandes/{commande.Id}";

            string json = JsonConvert.SerializeObject(commande);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }

        #endregion

        #region Transaction

        public static async Task<Transaction> GetTransaction(int transactionId)
        {
            string route = $"Transactions/{transactionId}";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string resultat = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Transaction>(resultat)
                    ?? throw new FormatException($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ObservableCollection<Transaction>> GetAllTransactions()
        {
            string route = $"Transactions";
            var response = await Client.GetAsync(route);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ObservableCollection<Transaction>>(result)
                ?? throw new Exception($"Erreur http : {route} ");
            }
            throw new Exception(response.ReasonPhrase);
        }

        public static async Task CreateTransaction(Transaction transaction)
        {
            string route = $"Transactions";
            string json = JsonConvert.SerializeObject(transaction);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PostAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task DeleteTransaction(int id)
        {
            string route = $"Transactions/{id}";
            var response = await Client.DeleteAsync(route);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task UpdateTransaction(Transaction transaction)
        {
            string route = $"Transactions/{transaction.Id}";

            string json = JsonConvert.SerializeObject(transaction);
            var buffer = Encoding.UTF8.GetBytes(json);

            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = await Client.PutAsync(route, byteContent);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"{response.ReasonPhrase}");
            }
        }

        #endregion
    }
}
