using Framework.Drivers;
using Framework.Extensions;
using Framework.Utils;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class BasePage
    {
        private readonly string _namePage;
        private readonly By _locator;
        private static Logger Logger => Logger.Instance;

        protected BasePage(string namePage, By locator)
        {
            _namePage = namePage;
            _locator = locator;
        }

        public bool IsPagePresent()
        {
            Logger.Info($"Is page [{_namePage}] opened");
            return BrowserFactory.GetDriver().FindElement(_locator).WaitForDisplayed(BrowserFactory.GetDriver());
        }
    }
}