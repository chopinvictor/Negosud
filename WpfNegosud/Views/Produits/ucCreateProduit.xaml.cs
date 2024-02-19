using Negosud.Class;
using Negosud.Dto;
using NegosudWpf.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using Type = Negosud.Class.Type;

namespace NegosudWpf.Views.Clients
{
    /// <summary>
    /// Logique d'interaction pour ucCreateClient.xaml
    /// </summary>
    public partial class ucCreateProduit : UserControl
    {
        public ucCreateProduit()
        {
            InitializeComponent();
        }

        public int DomaineId {  get; set; }

        public int TypeId { get; set; }

        private void CreateProduit_Click(object sender, RoutedEventArgs e)
        {
            var prix = Prix.Text.Replace(".", ",");

            var produit = new Produit()
            {
                NomProduit = Nom.Text,
                DomaineID = ((Domaine)comboBoxDomaineList.SelectedItem).Id,
                PrixProduit = double.Parse(prix),
                TypeID = ((Type)comboBoxTypeList.SelectedItem).Id,
                Quantite = int.Parse(Qte.Text)
            };

            ProduitsViewModel.Instance.CreateProduit(produit);
            MainViewModel.Instance.ChargerProduitList();
        }

        private void comboBoxDomaineList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Domaine domaine = (Domaine)((ComboBox)sender).SelectedItem;
            DomaineNom.Text = domaine.NomDomaine;
            DomaineAdresse.Text = domaine.AdresseDomaine;
            DomaineCP.Text = domaine.CodePostalDomaine;
            DomainePays.Text = domaine.PaysDomaine;
            DomaineVille.Text = domaine.VilleDomaine;
            DomaineId = domaine.Id;
        }

        private void comboBoxTypeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Type type = (Type)((ComboBox)sender).SelectedItem;
            TypeId = type.Id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerProduitList();
        }
    }
}
