using System;
using coursemanager.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace coursemanager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new LoginPage());
            navigationPage.BarBackgroundColor = (Color) App.Current.Resources["BackgroundColor"];
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
