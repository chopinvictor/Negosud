using Negosud.Class;
using NegosudWpf.Services;
using NegosudWpf.ViewModels;
using System.ComponentModel.Design;
using System.Windows;
using System.Windows.Controls;

namespace NegosudWpf.Views.Commandes_
{
    /// <summary>
    /// Logique d'interaction pour ucCreateCommande.xaml
    /// </summary>
    public partial class ucCreateCommande : UserControl
    {
        public ucCreateCommande()
        {
            InitializeComponent();
        }
        
        private void Fo_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Commander_Click(object sender, RoutedEventArgs e)
        {
            //var btn = (Button)sender;
            //var selectedProduits = ((CommandesViewModel)btn.DataContext).ListeSelectedProduits;
            //foreach (var produit in selectedProduits)
            //{
            //    produit.
            //}



            //    var temp = Pu.Text.Replace(".", ",");
            //    var pu = double.Parse(temp);
            //    var nb = int.Parse(Nb.Text);

            //    var tt = pu * nb;
            //    var roundtt = Math.Round((double)tt, 2);


            //    var commande = new Commande()
            //    {
            //        DateCommande = DateTime.Now,
            //        FournisseurId = ((Fournisseur)Fo.SelectedItem).Id,
            //        EstEntreeSortie = true,
            //        PrixTotal = roundtt,
            //        ClientId = 0,
            //        ListProduits = new List<Produit>(),
            //        Remise = 0
            //    };


            //    Task.Run(async () =>
            //    {
            //        return await CommandesViewModel.Instance.CreateCommande(commande);
            //    }).ContinueWith(t =>
            //    {
            //        if (t.Result != null)
            //        {
            //            var comId = t.Result.Id;
            //            var tr = new Transaction()
            //            {
            //                CommandeId = comId,
            //                Description = "Achat",
            //                Prix = pu,
            //                NbProduit = nb,
            //                ProduitId = ((CommandesViewModel)btn.DataContext).ProduitId
            //            };

            //            var prodDto = ((CommandesViewModel)btn.DataContext).Produit;
            //            var prod = new Produit()
            //            {
            //                Id = prodDto.Id,
            //                NbProduit = prodDto.Nombre,
            //                DomaineID = prodDto.Domaine.Id,
            //                TypeID = prodDto.Type.Id,
            //                Type = prodDto.Type,
            //                Domaine = prodDto.Domaine,
            //                NomProduit = prodDto.Nom,
            //                PrixProduit = prodDto.Prix,
            //                Quantite = prodDto.Quantite
            //            };

            //            prod.NbProduit += nb;

            //            TransactionsViewModel.Instance.CreateTransaction(tr);
            //            ProduitsViewModel.Instance.UpdateProduit(prod);
            //            MainViewModel.Instance.ChargerProduitList();
            //        }
            //    });
            //}

            //private void Fo_SelectionChanged(object sender, SelectionChangedEventArgs e)
            //{
            //    CommandesViewModel.Instance
            //}
        }
    }
}
