using Negosud.Class;
using NegosudWpf.Services;

using System.Collections.ObjectModel;


namespace NegosudWpf.ViewModels
{
    public class FournisseursViewModel : BaseViewModel
    {
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
    }
}
