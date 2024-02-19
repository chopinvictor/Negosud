﻿using Negosud.Class;
using Negosud.Dto;
using NegosudWpf.Services;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace NegosudWpf.ViewModels
{
    public class CommandesViewModel : BaseViewModel
    {
        #region Singleton
        private static CommandesViewModel instance = new CommandesViewModel();

        public static CommandesViewModel Instance { get => instance; }

        #endregion

        public Commande Commande { get; set; }

        public int CommandeId { get; set; }

        public int ProduitId { get; set; }

        public Fournisseur Fournisseur { get; set; }

        public ProduitDto Produit { get; set; }

        public ObservableCollection<Commande> ListeCommandes { get; set; }

        public ObservableCollection<Fournisseur> ListeFournisseurs { get; set; }
        public ObservableCollection<Client> ListeClients { get; set; }
        public ObservableCollection<ProduitDto> ListeProduits { get; set; }

        public Transaction Transaction { get; set; } = new Transaction();

        public CommandesViewModel()
        {
            GetAllProduits();
            GetAllClients();
        }

        public async void GetCommande(int commandeId)
        {
            Commande = await HttpClientService.GetCommande(commandeId);
            CommandeId = commandeId;
            OnPropertyChanged(nameof(Commande));
        }

        public async void GetAllCommandes()
        {
            ListeCommandes = await HttpClientService.GetAllCommandes();
            OnPropertyChanged(nameof(ListeCommandes));
        }
        
        public async void GetAllClients()
        {
            ListeClients = await HttpClientService.GetAllClients();
            OnPropertyChanged(nameof(ListeClients));
        }
        
        public async void GetAllProduits()
        {
            ListeProduits = await HttpClientService.GetAllProduits();
            OnPropertyChanged(nameof(ListeProduits));
        }

        public async Task<Commande> CreateCommande(Commande commande)
        {
            return await HttpClientService.CreateCommande(commande);
        }

        public async void UpdateCommande(Commande commande)
        {
            await HttpClientService.UpdateCommande(commande);
        }

        public async void DeleteCommande(int id)
        {
            await HttpClientService.DeleteCommande(id);
        }

        public async void CreateTransaction(Transaction transaction)
        {
            await HttpClientService.CreateTransaction(transaction); 
        }

    }
}