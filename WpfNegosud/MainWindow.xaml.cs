using Negosud.Dto;
using NegosudWpf.ViewModels;
using NegosudWpf.Views;
using System.Windows;

namespace WpfNegosud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = MainViewModel.Instance;
        }
    }
}