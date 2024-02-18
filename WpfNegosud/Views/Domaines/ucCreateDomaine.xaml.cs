using Negosud.Class;
using NegosudWpf.ViewModels;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NegosudWpf.Views.Domaines
{
    /// <summary>
    /// Logique d'interaction pour ucCreateDomaine.xaml
    /// </summary>
    public partial class ucCreateDomaine : UserControl
    {
        public ucCreateDomaine()
        {
            InitializeComponent();
        }


        private void CreateDomaineValidation_Click(object sender, RoutedEventArgs e)
        {
            var Domaine = new Domaine()
            {
                NomDomaine = Nom.Text,
                AdresseDomaine = Adresse.Text,
                CodePostalDomaine = CP.Text,
                VilleDomaine = Ville.Text,
                PaysDomaine = Pays.Text,
            };

            DomainesViewModel.Instance.CreateDomaine(Domaine);
        }

        private void ReturnDomaineList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerDomaineList();
        }
    }
}
