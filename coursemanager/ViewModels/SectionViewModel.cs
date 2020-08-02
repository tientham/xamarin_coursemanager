using System;
using coursemanager.Models;
using Prism.Mvvm;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class SectionViewModel : BindableBase
    {
        public SectionViewModel(Section section)
        {
            this.id = section.Id;
            this.title = section.Title;
            this.subTitle = section.Subtitle;
            this.videoUrl = section.VideoUrl;
            this.transcript = section.Transcript;
        }

        #region PROPERTIES

        private int id;
        public int Id
        {
            get => id;
            set
            {
                SetProperty(ref id, value);
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

        private string subTitle;
        public string SubTitle
        {
            get => subTitle;
            set
            {
                SetProperty(ref subTitle, value);
            }
        }

        private string videoUrl;
        public string VideoUrl
        {
            get => videoUrl;
            set
            {
                SetProperty(ref videoUrl, value);
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

    }
}
