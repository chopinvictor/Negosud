using Negosud.Class;
using NegosudWpf.Services;
using System.Collections.ObjectModel;

namespace NegosudWpf.ViewModels
{
    public class DomainesViewModel : BaseViewModel
    {
        #region Singleton
        private static DomainesViewModel instance = new DomainesViewModel();

        public static DomainesViewModel Instance { get => instance; }

        #endregion

        public Domaine Domaine { get; set; }

        public int DomaineId { get; set; }

        public ObservableCollection<Domaine> ListeDomaines { get; set; }

        public DomainesViewModel()
        {
            GetAllDomaines();
        }

        public async void GetDomaine(int domaineId)
        {
            Domaine = await HttpClientService.GetDomaine(domaineId);
            DomaineId = domaineId;
            OnPropertyChanged(nameof(Domaine));
        }

        public async Task<ObservableCollection<Domaine>> GetAllDomaines()
        {
            ListeDomaines = await HttpClientService.GetAllDomaines();
            OnPropertyChanged(nameof(ListeDomaines));
            return ListeDomaines;
        }

        public async void CreateDomaine(Domaine domaine)
        {
            await HttpClientService.CreateDomaine(domaine);
        }

        public async void UpdateDomaine(Domaine domaine)
        {
            await HttpClientService.UpdateDomaine(domaine);
        }

        public async void DeleteDomaine(int id)
        {
            await HttpClientService.DeleteDomaine(id);
        }
    }
}
