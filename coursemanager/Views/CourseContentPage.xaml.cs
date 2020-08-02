using System;
using System.Collections.Generic;
using coursemanager.ViewModels;
using Xamarin.Forms;

namespace coursemanager.Views
{
    public partial class CourseContentPage : ContentPage
    {
        public CourseContentPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetBackButtonTitle(this, "");
        }
    }
}
