using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class MyAccountHeaderForm: BasePage
    {
        public MyAccountHeaderForm() : base(nameof(MyAccountHeaderForm), By.CssSelector("div.Header-buttonsWrap-28"))
        {
        }
    }
}