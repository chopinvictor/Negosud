using Negosud.Class;
using NegosudWpf.Services;
using System.Collections.ObjectModel;
using Type = Negosud.Class.Type;

namespace NegosudWpf.ViewModels
{
    public class TypesViewModel : BaseViewModel
    {
        #region Singleton
        private static DomainesViewModel instance = new DomainesViewModel();

        public static DomainesViewModel Instance { get => instance; }

        #endregion

        public Type Type { get; set; }

        public int TypeId { get; set; }

        public ObservableCollection<Type> ListeTypes { get; set; }

        public TypesViewModel()
        {
        }

        public async Task<ObservableCollection<Type>> GetAllTypes()
        {
            ListeTypes = await HttpClientService.GetAllTypes();
            OnPropertyChanged(nameof(ListeTypes));
            return ListeTypes;
        }
    }
}
