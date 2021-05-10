using System;
using Framework.Models;
using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using JsonReader = Framework.Utils.JsonReader;

namespace Framework.Drivers
{
    public class BrowserFactory
    {
        private static IWebDriver _driver;
        private static Logger Logger => Logger.Instance;
        private static readonly BrowserSettings BrowserSettings = JsonReader.SetConfigModel<BrowserSettings>();
        
        private BrowserFactory() {
        }
        
        public static IWebDriver InitBrowser() 
        {
            if (_driver == null)
            {
                Logger.Info($"Browser [{BrowserSettings.Browser}] init");
                switch (BrowserSettings.Browser)
                {
                    case "chrome":
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        _driver = new ChromeDriver();
                        break;
                    case "firefox":
                        new DriverManager().SetUpDriver(new FirefoxConfig());
                        _driver = new FirefoxDriver();
                        break;
                }
            }
            return _driver;
        }
        
        public static void CloseBrowser() {
            Logger.Info("Close browser");
            if (_driver != null) {
                _driver.Quit();
            }
            _driver = null;
        }

        public static void SetImplicitlyWait() 
        {
            Logger.Info($"Set Implicitly Wait [{BrowserSettings.ImplicitlyWait}]");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(BrowserSettings.ImplicitlyWait);
        }

        public static void SetMaxSizeWindow() 
        {
            Logger.Info($"Set max size window");
            _driver.Manage().Window.Maximize();
        }

        public static void SetUrl() {
            Logger.Info($"Set URL [{BrowserSettings.Url}]");
            _driver.Navigate().GoToUrl(BrowserSettings.Url);
        }
    }
}