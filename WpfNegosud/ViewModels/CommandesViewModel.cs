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

        private CommandesViewModel()
        {
            GetAllProduits();
            GetAllClients();
            GetAllHistoriques();
        }

        #endregion

        public double PrixTotal
        {
            get { return PrixTotal; }
            set
            {
                double tt = 0;
                foreach (var prod in ListeSelectedProduits)
                {
                    tt += prod.PrixTotal;
                }
                Commande.PrixTotal = tt;
                OnPropertyChanged();
            }
        }

        public Commande Commande { get; set; }

        public int CommandeId { get; set; }

        public int ProduitId { get; set; }

        public Fournisseur Fournisseur { get; set; }

        public ProduitDto Produit { get; set; }

        public ObservableCollection<Commande> ListeCommandes { get; set; }

        public ObservableCollection<Fournisseur> ListeFournisseurs { get => ProduitsViewModel.Instance.ListeFournisseurs; }

        public ObservableCollection<Client> ListeClients { get; set; }

        public ObservableCollection<ProduitDto> ListeProduits { get; set; }

        public ObservableCollection<ProduitCommandeViewModel> ListeSelectedProduits { get; set; } = new ObservableCollection<ProduitCommandeViewModel>();

        public ObservableCollection<Transaction> ListeTransaction { get; set; } = new ObservableCollection<Transaction>();

        public ObservableCollection<Historique> ListHistoriques { get; set; }


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

        public async void CreateHistorique(Historique historique)
        {
            await HttpClientService.CreateHistorique(historique);
        }

        public async void GetAllHistoriques()
        {
            ListHistoriques = await HttpClientService.GetAllHistoriques();
            OnPropertyChanged(nameof(ListHistoriques));
        }
    }
}
