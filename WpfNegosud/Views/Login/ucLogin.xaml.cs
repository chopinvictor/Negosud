using NegosudWpf.Models;
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

namespace NegosudWpf.Views.Login
{
    /// <summary>
    /// Logique d'interaction pour login.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            var Login = new LoginUser()
            {
                Email = email.Text,
                Password = pwd.Text,

            };


            LoginViewModel.Instance.Login(Login.Email, Login.Password);
            MainViewModel.Instance.ChargerAccueil();
        }
    }
}
