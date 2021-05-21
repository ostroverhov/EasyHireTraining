using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Drivers
{
    public static class BrowserOptions
    {
        public static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            return chromeOptions;
        }

        public static FirefoxOptions GetFirefoxOptions()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");
            return firefoxOptions;
        }
    }
}