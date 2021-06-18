using System;
using System.Linq;
using Framework.Models;
using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Drivers
{
    public class BrowserFactory
    {
        private static Logger Logger => Logger.Instance;

        private static readonly BrowserSettings BrowserSettings = JsonReader.SetConfigModel<BrowserSettings>();

        [ThreadStatic] public static IWebDriver driver;

        private const string Chrome = "chrome";

        private const string Firefox = "firefox";

        private BrowserFactory()
        {
        }

        public static IWebDriver GetDriver()
        {
            if (driver == null) 
            {
                var browser = Environment.GetEnvironmentVariable("testBrowser") ?? BrowserSettings.Browser; 
                Logger.Info($"Browser [{browser}] init");
                switch (browser)
                {
                    case Chrome:
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver(BrowserOptions.GetChromeOptions());
                        break;
                    case Firefox:
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        driver = new FirefoxDriver(BrowserOptions.GetFirefoxOptions());
                        break;
                }
            }
            return driver;
        }
        
        public static void CloseBrowser() {
            Logger.Info("Close browser");
            driver.Quit();
            driver = null;
        }

        public static void SetImplicitlyWait() 
        {
            Logger.Info($"Set Implicitly Wait [{BrowserSettings.ImplicitlyWait}]");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(BrowserSettings.ImplicitlyWait);
        }

        public static void SetMaxSizeWindow() 
        {
            Logger.Info($"Set max size window");
            driver.Manage().Window.Maximize();
        }

        public static void SetUrl() {
            Logger.Info($"Set URL [{BrowserSettings.Url}]");
            driver.Navigate().GoToUrl(BrowserSettings.Url);
        }
        
        public static void SwitchToLastTab() {
            Logger.Info($"Switch to last tab");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
    }
}