using Negosud.Class;
using NegosudWpf.Services;
using System.Collections.ObjectModel;

namespace NegosudWpf.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Singleton
        private static LoginViewModel instance = new LoginViewModel();

        public static LoginViewModel Instance { get => instance; }

        #endregion

        public LoginViewModel()
        { }

        public async Task<bool> Login(string email, string pwd)
        {
            return await HttpClientService.Login(email, pwd);
        }

        public async void Register(string email, string pwd)
        {
            await HttpClientService.Register(email, pwd);
        }
    }
}
