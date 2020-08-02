using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using coursemanager.Interfaces;
using coursemanager.Services;
using coursemanager.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class CourseContentPageViewModel : BaseViewModel
    {
        private readonly ICourseService courseService;

        public CourseContentPageViewModel(INavigationService navigationService, ICourseService courseService)
            : base(navigationService)
        {
            this.courseService = courseService;
            var sections = courseService.GetCourseSections();
            CourseSections = new ObservableCollection<SectionViewModel>();
            if (sections.Count > 0)
            {
                sections.ForEach(s => CourseSections.Add(s));
            }

            ViewSectionCommand = new Command(ViewSectionCommandExecute);
        }

        #region PROPERTIES

        public ObservableCollection<SectionViewModel> CourseSections
        {
            get;
            set;
        }

        public ICommand ViewSectionCommand { get; }

        #endregion

        #region METHODS

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.GetNavigationMode() == NavigationMode.Back)
            {
                Debug.WriteLine(NavigationService.GetNavigationUriPath());
            }

            parameters.TryGetValue(NavigationParameterKeys.COURSE_CONTENT_TITLE, out string title);
            if (!string.IsNullOrEmpty(title))
            {
                Title = title;
            }

        }

        private async void ViewSectionCommandExecute(object obj)
        {
            // await Application.Current.MainPage.Navigation.PushAsync(new SectionDetailPage(obj as SectionViewModel));

            var param = new NavigationParameters();
            param.Add(NavigationParameterKeys.SECTION_DETAIL_INFO, obj);

            await NavigationService.NavigateAsync(nameof(SectionDetailPage), param);
        }

        #endregion
    }
}
