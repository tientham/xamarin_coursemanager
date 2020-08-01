using System;
using System.Collections.ObjectModel;
using coursemanager.Interfaces;
using coursemanager.Services;

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
        }

        #region PROPERTIES

        public ObservableCollection<SectionViewModel> CourseSections
        {
            get;
            set;
        }

        #endregion
    }
}
