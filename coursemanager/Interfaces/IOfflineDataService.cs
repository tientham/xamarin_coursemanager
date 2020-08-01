using System;
using System.Collections.Generic;
using coursemanager.Models;

namespace coursemanager.Interfaces
{
    public interface IOfflineDataService
    {
        List<Section> GetMockSections();
    }
}
