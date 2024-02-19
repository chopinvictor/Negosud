using Negosud.Class;
using Negosud.Dto;
using NegosudWpf.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views.Ventes
{
    /// <summary>
    /// Logique d'interaction pour ucCreateVente.xaml
    /// </summary>
    public partial class ucCreateVente : UserControl
    {
        public ucCreateVente()
        {
            InitializeComponent();
        }

        private async void CreateVente_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var vm = ((CommandesViewModel)btn.DataContext);

            

            var prodDto = (ProduitDto)comboBoxProduitList.SelectedItem;
            var nb = int.Parse(Qte.Text);
            prodDto.Nombre -= nb;

            var com = new Commande()
            {
                ClientId = ((Client)comboBoxClientList.SelectedItem).Id,
                EstEntreeSortie = false,
                DateCommande = DateTime.Now,
                PrixTotal = prodDto.Prix * nb,
                
            };
            var comAdded = await CommandesViewModel.Instance.CreateCommande(com);

            var prod = new Produit()
            {
                Id = prodDto.Id,
                NbProduit = prodDto.Nombre,
                DomaineID = prodDto.Domaine.Id,
                TypeID = prodDto.Type.Id,
                Type = prodDto.Type,
                Domaine = prodDto.Domaine,
                NomProduit = prodDto.Nom,
                PrixProduit = prodDto.Prix,
                Quantite = prodDto.Quantite
            };

            var tr = new Transaction()
            {
                CommandeId = comAdded.Id,
                Description = "Vente",
                Prix = prodDto.Prix,
                NbProduit = nb,
                ProduitId = prod.Id,
            };

            TransactionsViewModel.Instance.CreateTransaction(tr);
            ProduitsViewModel.Instance.UpdateProduit(prod);

            MainViewModel.Instance.ChargerProduitList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerAccueil();
        }
    }
}
