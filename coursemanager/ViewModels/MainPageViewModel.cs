using System;
using System.Diagnostics;
using System.Windows.Input;
using coursemanager.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            CourseContentCommand = new Command(CourseContentCommandExecute);

            Instructor = "To Minh Tien";
        }

        #region PROPERTIES

        public ICommand CourseContentCommand { get; }

        private string instructor;
        public string Instructor
        {
            get => instructor;
            set
            {
                SetProperty(ref instructor, value);
            }
        }

        #endregion

        #region METHODS

        private async void CourseContentCommandExecute(object obj)
        {
            // await Application.Current.MainPage.Navigation.PushAsync(new CourseContentPage("Xamarin Forms with MVVM and Prism"));
            var param = new NavigationParameters();
            param.Add(NavigationParameterKeys.COURSE_CONTENT_TITLE, "Xamarin Forms with MVVM and Prism");
            await NavigationService.NavigateAsync(nameof(CourseContentPage), param);
        }

        #endregion
    }
}
