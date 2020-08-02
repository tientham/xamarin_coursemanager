using System;
using System.Collections.Generic;
using System.Diagnostics;
using coursemanager.ViewModels;
using LibVLCSharp.Shared;
using Xamarin.Forms;

namespace coursemanager.Views
{
    // Free public test video: https://gist.github.com/jsturgis/3b19447b304616f18657
    public partial class SectionDetailPage : ContentPage
    {
        public SectionDetailPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            videoView.MediaPlayer?.Stop();
        }
    }
}
