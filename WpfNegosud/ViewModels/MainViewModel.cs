﻿using Negosud.Class;
using Negosud.Dto;
using NegosudWpf.Views;
using NegosudWpf.Views.Accueil;
using NegosudWpf.Views.Clients;
using NegosudWpf.Views.Commandes_;
using NegosudWpf.Views.Domaines;
using NegosudWpf.Views.Fournisseurs;
using NegosudWpf.Views.Login;
using NegosudWpf.Views.Transactions;
using NegosudWpf.Views.Ventes;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Windows.Controls;

namespace NegosudWpf.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Singleton
        private static MainViewModel instance = new MainViewModel();

        public static MainViewModel Instance { get => instance; }

        private MainViewModel() { }
        #endregion

        private UserControl userControl;

        public UserControl UserControl
        {
            get { return userControl; }
            set { userControl = value; OnPropertyChanged(); }
        }

        public void Refresh(object obj)
        {
            OnPropertyChanged(nameof(obj));
        }

        //Login

        public void ChargerLogin()
        {
            var uc = new ucLogin();
            UserControl = uc;
        }


        // Accueil
        public void ChargerAccueil()
        {
            var uc = new ucAccueil();
            UserControl = uc;
        }


        // Clients
        public void ChargerClient(int clientId)
        {
            var uc = new ucClientControl();
            uc.DataContext = new ClientsViewModel();
            ((ClientsViewModel)uc.DataContext).GetClient(clientId);
            uc.ClientId = clientId;
            UserControl = uc;
        }

        public void ChargerClientList()
        {
            var uc = new ucClientsList();
            uc.DataContext = new ClientsViewModel();
            UserControl = uc;
        }

        public void CreateClient()
        {
            var uc = new ucCreateClient();
            uc.DataContext = new ClientsViewModel();
            UserControl = uc;
        }

        public async void ChargerProduit(int produitId, int domaineId, int typeId)
        {
            var uc = new ucProduitControl();
            uc.DataContext = ProduitsViewModel.Instance;
            ((ProduitsViewModel)uc.DataContext).GetProduit(produitId);
            uc.ProduitId = produitId;
            uc.TypeId = typeId;
            uc.DomaineId = domaineId;
            UserControl = uc;
        }

        public void ChargerProduitList()
        {
            var uc = new ucProduitsList();
            uc.DataContext = ProduitsViewModel.Instance;
            UserControl = uc;
        }

        public void CreateProduit()
        {
            var uc = new ucCreateProduit();
            uc.DataContext = ProduitsViewModel.Instance;
            ((ProduitsViewModel)uc.DataContext).GetAllDomAndType();
            UserControl = uc;
        }


        // Fournisseurs
        public void ChargerFournisseurList()
        {
            var uc = new ucFournisseursList();
            uc.DataContext = new FournisseursViewModel();
            UserControl = uc;
        }

        public void ChargerFournisseur(int fournisseurId)
        {
            var uc = new ucAddFournisseur();
            uc.DataContext = new FournisseursViewModel();
            ((FournisseursViewModel)uc.DataContext).GetFournisseur(fournisseurId);
            uc.FournisseurId = fournisseurId;
            UserControl = uc;
        }

        public void CreateFournisseur()
        {
            var uc = new ucCreateFournisseur();
            uc.DataContext = new FournisseursViewModel();
            UserControl = uc;
        }

        // Domaine
        public void ChargerDomaine(int domaineId)
        {
            var uc = new ucDomaineControl();
            uc.DataContext = new DomainesViewModel();
            ((DomainesViewModel)uc.DataContext).GetDomaine(domaineId);
            uc.DomaineId = domaineId;
            UserControl = uc;
        }

        public void ChargerDomaineList()
        {
            var uc = new ucDomaineList();
            uc.DataContext = new DomainesViewModel();
            UserControl = uc;
        }

        public void CreateDomaine()
        {
            var uc = new ucCreateDomaine();
            uc.DataContext = new DomainesViewModel();
            UserControl = uc;
        }
        public void ChargerCommande()
        {
            var uc = new ucCreateTransaction();
            uc.DataContext = new TransactionsViewModel();
            UserControl = uc;
        }

        public void ChargerCommandeProduit(ProduitCommandeDto produit)
        {
            var uc = new ucCreateCommande();
            uc.DataContext = CommandesViewModel.Instance;
            ((CommandesViewModel)uc.DataContext).ProduitId = produit.Id;
            ((CommandesViewModel)uc.DataContext).ListeSelectedProduits.Add(new ProduitCommandeViewModel(produit));


            UserControl = uc;
        }

        public void ChargerRecap(int commandeId, int produitId)
        {
            var uc = new ucRecapCommande();
            uc.DataContext = CommandesViewModel.Instance;
            ((CommandesViewModel)uc.DataContext).GetCommande(commandeId);
            ((CommandesViewModel)uc.DataContext).ProduitId = produitId;
            UserControl = uc;
        }

        public void ChargerCreateVente()
        {
            var uc = new ucCreateVente();
            uc.DataContext = CommandesViewModel.Instance;
            UserControl = uc;
        }

        //public void CreateCommande()
        //{
        //    var uc = new ucCreateCommande();
        //    uc.DataContext = new CommandesViewModel();
        //    UserControl = uc;
        //}

    }
}
