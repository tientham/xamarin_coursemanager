using System;
using System.Collections.Generic;
using coursemanager.ViewModels;
using Xamarin.Forms;

namespace coursemanager.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = new MainPageViewModel();
        }
    }
}
