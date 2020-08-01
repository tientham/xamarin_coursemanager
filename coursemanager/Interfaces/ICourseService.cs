using System;
using System.Collections.Generic;
using coursemanager.ViewModels;

namespace coursemanager.Interfaces
{
    public interface ICourseService
    {
        List<SectionViewModel> GetCourseSections();
    }
}
