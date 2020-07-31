using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace coursemanager.Views
{
    public partial class CourseContentPage : ContentPage
    {
        public CourseContentPage(string title)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            NavigationPage.SetBackButtonTitle(this, "");
            Title = title;
        }
    }
}
