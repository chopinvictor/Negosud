using Negosud.Class;
using NegosudWpf.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ucDomaineControl.xaml
    /// </summary>
    public partial class ucDomaineControl : UserControl
    {
        public Domaine Domaine = new Domaine();

        public int DomaineId { get; set; }

        public ucDomaineControl()
        {
            InitializeComponent();
        }
        private void UpdateDomaineValidation_Click(object sender, RoutedEventArgs e)
        {
            var domaine = new Domaine()
            {
                Id = DomaineId,
                NomDomaine = Nom.Text,
                AdresseDomaine = Adresse.Text,
                CodePostalDomaine = CP.Text,
                VilleDomaine = Ville.Text,
                PaysDomaine = Pays.Text,

            };
            DomainesViewModel.Instance.UpdateDomaine(domaine);
        }

        private void DeleteDomaine_Click(object sender, RoutedEventArgs e)
        {
            DomainesViewModel.Instance.DeleteDomaine(DomaineId);
        }

        private void ReturnDomaineList_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.Instance.ChargerDomaineList();
        }
    }
}
