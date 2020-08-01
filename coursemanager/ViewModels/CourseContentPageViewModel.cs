using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using coursemanager.Interfaces;
using coursemanager.Services;
using Xamarin.Forms;

namespace coursemanager.ViewModels
{
    public class CourseContentPageViewModel : BaseViewModel
    {
        private readonly ICourseService courseService;

        public CourseContentPageViewModel()
        {
            this.courseService = new CourseService();
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

        private void ViewSectionCommandExecute(object obj)
        {
            ;
        }

        #endregion
    }
}
