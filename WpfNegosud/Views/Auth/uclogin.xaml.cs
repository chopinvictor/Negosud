using Negosud.Dao;
using NegosudWpf.Model;
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

namespace NegosudWpf.Views.Auth
{
    /// <summary>
    /// Logique d'interaction pour uclogin.xaml
    /// </summary>
    public partial class uclogin : UserControl
    {
        public uclogin()
        {
            InitializeComponent();
        }

        private void LoginValidation_Click(object sender, RoutedEventArgs e)
        {
            var log = new LoginUser()
            {
                Email = Email.Text,
                Password = Password.Text,
            };
            // a changer
            FournisseursViewModel.Instance.LoginUser(string Email, string Password);
        }
    }
}
