using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class MyAccountSideBar: BasePage
    {
        public MyAccountSideBar() : base(nameof(MyAccountSideBar), By.CssSelector("[alt*=Easyhire]"))
        {
        }
    }
}