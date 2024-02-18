﻿using Negosud.Class;
using Negosud.Dto;
using NegosudWpf.Services;
using System;
using System.Collections.ObjectModel;
using Type = Negosud.Class.Type;

namespace NegosudWpf.ViewModels
{
    public class ProduitsViewModel : BaseViewModel
    {
        #region Singleton
        private static ProduitsViewModel instance = new ProduitsViewModel();

        public static ProduitsViewModel Instance { get => instance; }

        #endregion

        public ProduitDto Produit { get; set; }

        public int ProduitId { get; set; }

        public int TypeId { get; set; }

        public int DomaineId { get; set; }

        public ObservableCollection<ProduitDto> ListeProduits { get; set; }
        public ObservableCollection<Domaine> ListeDomaines { get; set; }
        public ObservableCollection<string> ComboList { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<Type> ListeTypes { get; set; }

        public ProduitsViewModel()
        {
            GetAllProduits();
        }

        public async void GetProduit(int produitId)
        {
            Produit = await HttpClientService.GetProduit(produitId);
            ListeDomaines = await HttpClientService.GetAllDomaines();

            foreach(var dom in ListeDomaines)
            {
                ComboList.Add(dom.NomDomaine.ToString());
            }

            ListeTypes = await HttpClientService.GetAllTypes();
            ProduitId = produitId;
            TypeId = Produit.Type.Id;
            DomaineId = Produit.Domaine.Id;
            OnPropertyChanged(nameof(Produit));
            OnPropertyChanged(nameof(ListeDomaines));
            OnPropertyChanged(nameof(ListeTypes));

        }

        public async Task GetAllProduits()
        {
            ListeProduits = await HttpClientService.GetAllProduits();
            OnPropertyChanged(nameof(ListeProduits));
        }

        public async void CreateProduit(Produit produit)
        {
            await HttpClientService.CreateProduit(produit);
        }

        public async void UpdateProduit(Produit produit) 
        {
            await HttpClientService.UpdateProduit(produit);
        }

        public async void DeleteProduit(int id)
        {
            await HttpClientService.DeleteProduit(id);
        }

        public async void RefreshProduit()
        {
            OnPropertyChanged(nameof(Produit));
        }
    }
}
