using System;
using System.Collections.Generic;
using coursemanager.ViewModels;
using Xamarin.Forms;

namespace coursemanager.Views
{
    public partial class SectionDetailPage : ContentPage
    {
        public SectionDetailPage(SectionViewModel section)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            BindingContext = new SectionDetailPageViewModel(section);
            Title = $"Lecture {section.Id}";
        }
    }
}
