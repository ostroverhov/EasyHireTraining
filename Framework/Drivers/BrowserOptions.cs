using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Drivers
{
    public static class BrowserOptions
    {
        public static ChromeOptions GetChromeOptions()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            return chromeOptions;
        }

        public static FirefoxOptions GetFirefoxOptions()
        {
            var firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");
            return firefoxOptions;
        }
    }
}