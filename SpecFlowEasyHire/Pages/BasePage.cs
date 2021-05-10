using Framework.Drivers;
using Framework.Extensions;
using Framework.Utils;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class BasePage
    {
        protected readonly string NamePage;
        private readonly By Locator;
        protected static Logger Logger => Logger.Instance;

        public BasePage(string namePage, By locator)
        {
            NamePage = namePage;
            Locator = locator;
        }

        public bool IsPagePresent()
        {
            Logger.Info($"Is page [{NamePage}] opened");
            return BrowserFactory.InitBrowser().FindElement(Locator).WaitForDisplayed();
        }
    }
}