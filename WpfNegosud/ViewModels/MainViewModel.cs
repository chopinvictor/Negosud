using NegosudWpf.Views;
using System.Windows.Controls;

namespace NegosudWpf.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Singleton
        private static MainViewModel instance = new MainViewModel();

        public static MainViewModel Instance { get => instance; }

        private MainViewModel() { }
        #endregion

        private UserControl userControl;

        public UserControl UserControl
        {
            get { return userControl; }
            set { userControl = value; OnPropertyChanged(); }
        }

        public void ChargerClient(int clientId)
        {
            var uc = new ucClientControl();
            uc.DataContext = new ClientsViewModel();
            ((ClientsViewModel)uc.DataContext).GetClient(clientId);
            uc.ClientId = clientId;
            UserControl = uc;
        }

        public void ChargerClientList()
        {
            var uc = new ucClientsList();
            uc.DataContext = new ClientsViewModel();
            UserControl = uc;
        }

        public void CreateClient()
        {
            var uc = new ucClientControl();
            uc.DataContext = new ClientsViewModel();
            UserControl = uc;
        }

        public async void ChargerProduit(int produitId, int domaineId, int typeId)
        {
            var uc = new ucProduitControl();
            uc.DataContext = new ProduitsViewModel();
            ((ProduitsViewModel)uc.DataContext).GetProduit(produitId);
            uc.ProduitId = produitId;
            uc.TypeId = typeId;
            uc.DomaineId = domaineId;
            UserControl = uc;
        }

        public void ChargerProduitList()
        {
            var uc = new ucProduitsList();
            uc.DataContext = new ProduitsViewModel();
            UserControl = uc;
        }

        public void CreateProduit()
        {
            var uc = new ucProduitControl();
            uc.DataContext = new ProduitsViewModel();
            UserControl = uc;
        }
    }
}
