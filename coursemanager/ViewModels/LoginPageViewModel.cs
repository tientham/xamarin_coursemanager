using System;
using System.Diagnostics;
using System.Windows.Input;
using coursemanager.Views;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel()
        {
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
            await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
        }

        #endregion
    }
}
