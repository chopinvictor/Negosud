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

namespace NegosudWpf.Views
{
    /// <summary>
    /// Logique d'interaction pour ClientControl1.xaml
    /// </summary>
    public partial class ClientControl1 : UserControl
    {
        public ClientControl1()
        {
            InitializeComponent();
            var vm = (ClientsViewModel)this.DataContext;
            vm.GetClient(1);
        }

    }
}
