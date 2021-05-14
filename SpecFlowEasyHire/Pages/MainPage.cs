using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class MainPage: BasePage
    {
        public MainPage(IWebDriver webDriver) : base(nameof(MainPage), By.TagName("video"), webDriver)
        {
        }

        private Button SignUpButton => new Button("Sign Up", By.XPath("//span[contains(text(), 'Free sign up')]"), WebDriver);

        public void ClickSignUpButton() => SignUpButton.Click();
    }
}