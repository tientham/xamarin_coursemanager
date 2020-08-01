using System;
using System.Windows.Input;
using LibVLCSharp.Shared;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class SectionDetailPageViewModel : BaseViewModel
    {
        private LibVLC _libVLC;

        public SectionDetailPageViewModel(SectionViewModel section)
        {
            this.title = section.Title;
            this.Transcript = section.Transcript;
            this.imageVisible = true;

            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC)
            {
                Media = new Media(_libVLC, new Uri(section.VideoUrl))
            };

            PlayVideoCommand = new Command(PlayVideoCommandExecute);
        }

        #region PROPERTIES

        public ICommand PlayVideoCommand { get; }

        private MediaPlayer _mediaPlayer;
        public MediaPlayer MediaPlayer
        {
            get => _mediaPlayer;
            set
            {
                SetProperty(ref _mediaPlayer, value);
            }
        }

        private bool imageVisible;
        public bool ImageVisible
        {
            get => imageVisible;
            set
            {
                SetProperty(ref imageVisible, value);
            }
        }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                SetProperty(ref title, value);
            }
        }

        private string transcript;
        public string Transcript
        {
            get => transcript;
            set
            {
                SetProperty(ref transcript, value);
            }
        }

        #endregion

        #region

        private void PlayVideoCommandExecute(object obj)
        {
            ImageVisible = false;
            _mediaPlayer.Play();
        }

        public void StopVideo()
        {
            _mediaPlayer.Stop();
        }

        #endregion
    }
}
