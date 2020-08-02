using System;
using System.Windows.Input;
using LibVLCSharp.Shared;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class SectionDetailPageViewModel : BaseViewModel
    {
        private readonly IPageDialogService dialogService;

        private LibVLC _libVLC;

        public SectionDetailPageViewModel(INavigationService navationService, IPageDialogService dialogService)
            : base(navationService)
        {
            this.dialogService = dialogService;
            this.imageVisible = true;
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

        private string sectionTitle;
        public string SectionTitle
        {
            get => sectionTitle;
            set
            {
                SetProperty(ref sectionTitle, value);
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

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            parameters.TryGetValue<SectionViewModel>(NavigationParameterKeys.SECTION_DETAIL_INFO, out var sectionVM);

            if (sectionVM != null)
            {
                this.Title = $"Lecture {sectionVM.Id}";
                this.SectionTitle = sectionVM.Title;
                this.Transcript = sectionVM.Transcript;

                Core.Initialize();
                _libVLC = new LibVLC();
                MediaPlayer = new MediaPlayer(_libVLC)
                {
                    Media = new Media(_libVLC, new Uri(sectionVM.VideoUrl))
                };
                // RaisePropertyChanged(nameof(MediaPlayer));
            } else
            {
                await dialogService.DisplayAlertAsync("Error", "Unable to get section information!", "OK");
                await NavigationService.GoBackAsync();
                return;
            }
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
            // MediaPlayer.Stop();
        }

        private void PlayVideoCommandExecute(object obj)
        {
            ImageVisible = false;
            MediaPlayer.Play();
        }

        #endregion
    }
}
