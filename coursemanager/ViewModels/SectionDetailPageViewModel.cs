using System;
namespace coursemanager.ViewModels
{
    public class SectionDetailPageViewModel : BaseViewModel
    {
        public SectionDetailPageViewModel(SectionViewModel section)
        {
            this.title = section.Title;
            this.Transcript = section.Transcript;
        }

        #region PROPERTIES

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
    }
}
