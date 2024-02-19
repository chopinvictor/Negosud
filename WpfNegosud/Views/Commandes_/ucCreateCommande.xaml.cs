using Negosud.Class;
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

        private void Commander_Click(object sender, RoutedEventArgs e)
        {
            var temp = Pu.Text.Replace(".", ",");
            var pu = double.Parse(temp);
            var nb = int.Parse(Nb.Text);

            var tt = pu * nb;
            var roundtt = Math.Round((double)tt, 2);

            var commande = new Commande()
            {
                DateCommande = DateTime.Now,
                FournisseurId = ((Fournisseur)Fo.SelectedItem).Id,
                EstEntreeSortie = true,
                PrixTotal = roundtt,
                ClientId = 0,
                ListProduits = new List<Produit>(),
                Remise = 0
            };

            var btn = sender as Button;
            CommandesViewModel.Instance.CreateCommande(commande);

            MainViewModel.Instance.ChargerCommande();

            //Charger une fenetre transac vide en chargeant la commande ou commandId et creer dedans la transac puis retourner au menu 
            MainViewModel.Instance.CreateTransac(commande, pu, nb, ((CommandesViewModel)btn.DataContext).ProduitId);
        }
    }
}
