using System;
using System.Collections.Generic;
using coursemanager.ViewModels;
using LibVLCSharp.Shared;
using Xamarin.Forms;

namespace coursemanager.Views
{
    // Free public test video: https://gist.github.com/jsturgis/3b19447b304616f18657
    public partial class SectionDetailPage : ContentPage
    {
        public SectionDetailPage(SectionViewModel section)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            BindingContext = new SectionDetailPageViewModel(section);
            Title = $"Lecture {section.Id}";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            (BindingContext as SectionDetailPageViewModel).StopVideo();
        }
    }
}
