namespace Framework.Models
{
    public class BrowserSettings
    {
        public string Browser { get; set; }
        
        public string Url { get; set; }
        
        public int ImplicitlyWait { get; set; }
        
        public bool IsRemote { get; set; }
        
        public string RemoteUrl { get; set; }
    }
}