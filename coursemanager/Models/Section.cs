using System;
using Newtonsoft.Json;

namespace coursemanager.Models
{
    public class Section
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subTitle")]
        public string Subtitle { get; set; }

        [JsonProperty("videoUrl")]
        public string VideoUrl { get; set; }

        [JsonProperty("transcript")]
        public string Transcript { get; set; }
    }
}
