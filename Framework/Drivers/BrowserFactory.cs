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
        
        private static  readonly BrowserSettings BrowserSettings = JsonReader.SetConfigModel<BrowserSettings>();
        
        private readonly Lazy<IWebDriver> _currentWebDriverLazy;

        private const string Chrome = "chrome";

        private const string Firefox = "firefox";
        
        public BrowserFactory()
        {
            _currentWebDriverLazy = new Lazy<IWebDriver>(InitBrowser);
        }
        
        public IWebDriver InitBrowser()
        {
            IWebDriver driver = null;
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
            return driver;
        }
        
        public IWebDriver Current => _currentWebDriverLazy.Value;
        
        public static void CloseBrowser(IWebDriver driver) {
            Logger.Info("Close browser");
            driver.Quit();
        }

        public static void SetImplicitlyWait(IWebDriver driver) 
        {
            Logger.Info($"Set Implicitly Wait [{BrowserSettings.ImplicitlyWait}]");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(BrowserSettings.ImplicitlyWait);
        }

        public static void SetMaxSizeWindow(IWebDriver driver) 
        {
            Logger.Info($"Set max size window");
            driver.Manage().Window.Maximize();
        }

        public static void SetUrl(IWebDriver driver) {
            Logger.Info($"Set URL [{BrowserSettings.Url}]");
            driver.Navigate().GoToUrl(BrowserSettings.Url);
        }
        
        public static void SwitchToLastTab(IWebDriver driver) {
            Logger.Info($"Switch to last tab");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
    }
}