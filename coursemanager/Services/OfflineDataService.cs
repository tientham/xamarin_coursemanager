using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using coursemanager.Interfaces;
using coursemanager.Models;
using coursemanager.Views;
using Newtonsoft.Json;

namespace coursemanager.Services
{
    public class OfflineDataService : IOfflineDataService
    {
        public OfflineDataService()
        {
        }

        public List<Section> GetMockSections()
        {
            string jsonFileName = "mock_sections.json";
            var sections = new List<Section>();
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
            using (var reader = new StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                sections = JsonConvert.DeserializeObject<List<Section>>(jsonString);
            }

            return sections;
        }
    }
}
