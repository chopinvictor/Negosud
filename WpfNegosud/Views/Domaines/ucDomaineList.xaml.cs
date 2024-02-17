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
    /// Logique d'interaction pour ucDomaineList.xaml
    /// </summary>
    public partial class ucDomaineList : UserControl
    {
        public ucDomaineList()
        {
            InitializeComponent();
        }

        private void DomaineDetails_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            MainViewModel.Instance.ChargerDomaine(((Domaine)btn.DataContext).Id);
        }
       private void DomaineCreate_Click(object sender, RoutedEventArgs e)
       {
            MainViewModel.Instance.CreateDomaine();
       }
    }
}
