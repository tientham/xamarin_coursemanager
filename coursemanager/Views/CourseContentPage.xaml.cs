using System;
using System.Collections.Generic;
using coursemanager.ViewModels;
using Xamarin.Forms;

namespace coursemanager.Views
{
    public partial class CourseContentPage : ContentPage
    {
        public CourseContentPage(string title)
        {
            InitializeComponent();

            BindingContext = new CourseContentPageViewModel();

            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetBackButtonTitle(this, "");
            Title = title;
        }
    }
}
