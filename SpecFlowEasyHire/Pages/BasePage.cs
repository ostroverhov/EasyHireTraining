using Framework.Extensions;
using Framework.Utils;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class BasePage
    {
        private readonly string _namePage;
        private readonly By _locator;
        public readonly IWebDriver WebDriver;
        private static Logger Logger => Logger.Instance;

        protected BasePage(string namePage, By locator, IWebDriver webDriver)
        {
            _namePage = namePage;
            _locator = locator;
            WebDriver = webDriver;
        }

        public bool IsPagePresent()
        {
            Logger.Info($"Is page [{_namePage}] opened");
            return WebDriver.FindElement(_locator).WaitForDisplayed(WebDriver);
        }
    }
}