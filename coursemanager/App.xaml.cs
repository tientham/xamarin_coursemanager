using System;
using coursemanager.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace coursemanager
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer)
        {
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage();
            navigationPage.BarBackgroundColor = (Color)App.Current.Resources["BackgroundColor"];
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;

            await NavigationService.NavigateAsync($"{nameof(LoginPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginPage>(nameof(LoginPage));
            containerRegistry.RegisterForNavigation<MainPage>("MainPage");
            containerRegistry.RegisterForNavigation<CourseContentPage>(nameof(CourseContentPage));
            containerRegistry.RegisterForNavigation<SectionDetailPage>(nameof(SectionDetailPage));
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
