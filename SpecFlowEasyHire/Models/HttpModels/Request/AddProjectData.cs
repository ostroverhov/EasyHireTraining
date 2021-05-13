using Newtonsoft.Json;

namespace SpecFlowEasyHire.Models.HttpModels.Request
{
    public class AddProjectData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("announcement")]
        public string Announcement { get; set; }

        [JsonProperty("show_announcement")]
        public bool ShowAnnouncement { get; set; }

        [JsonProperty("suite_mode")]
        public int SuiteMode { get; set; }
    }
}