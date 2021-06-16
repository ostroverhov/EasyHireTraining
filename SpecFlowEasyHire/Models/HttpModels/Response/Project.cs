namespace SpecFlowEasyHire.Models.HttpModels.Response
{
    public class Project
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Announcement { get; set; }
        
        public bool ShowAnnouncement { get; set; }
        
        public bool IsCompleted { get; set; }
        
        public object CompletedOn { get; set; }
        
        public int SuiteMode { get; set; }
        
        public string Url { get; set; }
    }
}