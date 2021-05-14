using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class MyAccountSideBar: BasePage
    {
        public MyAccountSideBar(IWebDriver webDriver) : base(nameof(MyAccountSideBar), By.CssSelector("[alt*=Easyhire]"), webDriver)
        {
        }
    }
}