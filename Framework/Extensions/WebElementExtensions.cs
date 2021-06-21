using System;
using Framework.Models;
using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Extensions
{
    public static class WebElementExtensions
    {
        private static readonly BrowserSettings BrowserSettings = JsonReader.SetConfigModel<BrowserSettings>();

        public static bool WaitForDisplayed(this IWebElement element, IWebDriver webDriver) =>
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(BrowserSettings.ImplicitlyWait))
                .Until(condition => element.Displayed);

        public static bool WaitForText(this IWebElement element, IWebDriver webDriver) =>
            new WebDriverWait(webDriver, TimeSpan.FromSeconds(BrowserSettings.ImplicitlyWait))
                .Until(condition => element.Text != string.Empty);
    }
}