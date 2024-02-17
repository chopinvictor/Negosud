using Negosud.Class;
using NegosudWpf.Services;

using System.Collections.ObjectModel;


namespace NegosudWpf.ViewModels
{
    public class FournisseursViewModel : BaseViewModel
    {
        
        private static FournisseursViewModel instance = new FournisseursViewModel();

        public static FournisseursViewModel Instance { get => instance; }
        public Fournisseur Fournisseur { get; set; }

        
        public ObservableCollection<Fournisseur> ListeFournisseurs { get; set; }

        public FournisseursViewModel()
        {
            GetAllFournisseurs();
        }


        public async void GetFournisseur(int FournisseurId)
        {
            Fournisseur = await HttpClientService.GetFournisseur(FournisseurId);
            OnPropertyChanged(nameof(Fournisseur));
        }

        public async Task GetAllFournisseurs()
        {
            ListeFournisseurs = await HttpClientService.GetAllFournisseurs();
            OnPropertyChanged(nameof(ListeFournisseurs));
        }

        public async void CreateFournisseur(Fournisseur fournisseur)
        {
            await HttpClientService.CreateFournisseur(fournisseur);
        }

        // A faire marcher
        public async void UpdateFournisseur(Fournisseur fournisseur)
        {
            await HttpClientService.UpdateFournisseur(fournisseur);
        }
        public async void DeleteFournisseur(int id)
        {
            await HttpClientService.DeleteFournisseur(id);
        }
    }
}
