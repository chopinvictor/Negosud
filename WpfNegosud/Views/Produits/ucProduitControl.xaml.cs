using Microsoft.VisualBasic;
using Negosud.Class;
using NegosudWpf.Services;
using NegosudWpf.ViewModels;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using static System.Net.Mime.MediaTypeNames;
using Type = Negosud.Class.Type;

namespace NegosudWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour ClientControl1.xaml
    /// </summary>
    public partial class ucProduitControl : UserControl
    {
        public DomainesViewModel DomainesViewModel { get; set; } = new DomainesViewModel();

        public Produit Produit = new Produit();

        public ObservableCollection<Domaine> DomainesList;

        public ObservableCollection<Type> TypesList = new ObservableCollection<Type>();

        public int ProduitId { get; set; }

        public int DomaineId { get; set; }

        public int TypeId { get; set; }


        public ucProduitControl()
        {
            InitializeComponent();
        }
        private void UpdateProduitValidation_Click(object sender, RoutedEventArgs e)
        {
            var temp = Prix.Text.Replace(".", ",");

            double prix;
            double.TryParse(temp, out prix);

            int nombre;
            int.TryParse(Nb.Text, out nombre);

            int qte;

            if (Qte.Text != "")
                qte = int.Parse(Qte.Text);
            else
                qte = 0;

            var produit = new Produit()
            {
                Id = ProduitId,
                NomProduit = Nom.Text,
                PrixProduit = prix,
                NbProduit = nombre,
                DomaineID = DomaineId,
                TypeID = TypeId,
                Quantite = qte
            };
            ProduitsViewModel.Instance.UpdateProduit(produit);
        }

        private void DeleteProduit_Click(object sender, RoutedEventArgs e)
        {
            ProduitsViewModel.Instance.DeleteProduit(ProduitId);
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

        private void ReturnProduitList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerProduitList();
        }
    }
}
