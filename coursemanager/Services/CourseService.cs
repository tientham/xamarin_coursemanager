using System;
using System.Collections.Generic;
using System.Linq;
using coursemanager.Interfaces;
using coursemanager.Models;
using coursemanager.ViewModels;

namespace coursemanager.Services
{
    public class CourseService : ICourseService
    {
        private readonly IOfflineDataService offlineDataService;

        public CourseService()
        {
            this.offlineDataService = new OfflineDataService();
        }

        public List<SectionViewModel> GetCourseSections()
        {
            var sections = this.offlineDataService.GetMockSections();

            return sections.Select(x => GetSectionViewModel(x)).ToList();
        }

        private SectionViewModel GetSectionViewModel(Section section)
        {
            return new SectionViewModel(section);
        }
    }
}
