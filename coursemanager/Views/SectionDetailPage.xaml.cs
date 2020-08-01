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
        LibVLC _libVLC;
        MediaPlayer _mediaPlayer;
        string _videoUrl;

        public SectionDetailPage(SectionViewModel section)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            BindingContext = new SectionDetailPageViewModel(section);
            Title = $"Lecture {section.Id}";
            _videoUrl = section.VideoUrl;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC)
            {
                Media = new Media(_libVLC, new Uri(_videoUrl))
            };
            videoView.MediaPlayer = _mediaPlayer;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            _mediaPlayer.Stop();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            playImage.IsVisible = false;
            _mediaPlayer.Play();
        }
    }
}
