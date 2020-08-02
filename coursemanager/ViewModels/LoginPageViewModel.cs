using System;
using System.Diagnostics;
using System.Windows.Input;
using coursemanager.Views;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        private readonly IPageDialogService pageDialogService;

        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService)
        {
            this.pageDialogService = pageDialogService;

            LoginCommand = new Command(LoginCommandExecute);
        }

        #region PROPERTIES

        public ICommand LoginCommand { get; }

        private string username;
        public string Username
        {
            get => username;
            set
            {
                Debug.WriteLine($"Set username: {value}");
                SetProperty(ref username, value);
            }
        }

        private string password;
        public string Password
        {
            get => password;
            set
            {
                SetProperty(ref password, value);
            }
        }

        #endregion

        #region METHODS

        private async void LoginCommandExecute(object obj)
        {
            var canLogin = !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);

            if (!canLogin)
            {
                await this.pageDialogService.DisplayAlertAsync("Warning", "Must not empty fields!", "OK");
                return;
            }

            // await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            await NavigationService.NavigateAsync(nameof(MainPage));
        }

        #endregion
    }
}
