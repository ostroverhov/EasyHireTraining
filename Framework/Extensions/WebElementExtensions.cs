using System;
using Framework.Drivers;
using Framework.Models;
using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Extensions
{
    public static class WebElementExtensions
    {
        private static readonly BrowserSettings BrowserSettings = JsonReader.SetConfigModel<BrowserSettings>();
        
        public static bool WaitForDisplayed(this IWebElement element) => 
            new WebDriverWait(BrowserFactory.InitBrowser(), TimeSpan.FromSeconds(BrowserSettings.ImplicitlyWait))
                .Until(condition => element.Displayed);
    }
}