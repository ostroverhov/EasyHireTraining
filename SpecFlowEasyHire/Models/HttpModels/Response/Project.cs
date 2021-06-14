using Newtonsoft.Json;

namespace SpecFlowEasyHire.Models.HttpModels.Response
{
    public class Project
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("announcement")]
        public string Announcement { get; set; }
        
        [JsonProperty("show_announcement")]
        public bool ShowAnnouncement { get; set; }
        
        [JsonProperty("is_completed")]
        public bool IsCompleted { get; set; }
        
        [JsonProperty("completed_on")]
        public object CompletedOn { get; set; }
        
        [JsonProperty("suite_mode")]
        public int SuiteMode { get; set; }
        
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}