using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class LoginForm : BasePage
    {
        public LoginForm(IWebDriver webDriver) : base(nameof(LoginForm), By.CssSelector("header.MuiPaper-root"), webDriver)
        {
        }

        private TextBox EmailTextBox => new TextBox($"Login", By.Name("email"), WebDriver);
        private TextBox PasswordTextBox => new TextBox("Password", By.Name("password"), WebDriver);
        private Button LoginButton => new Button("Login",
            By.XPath("//button//span[@class='MuiTouchRipple-root']/preceding-sibling::span[contains(text(), 'Log in')]"), WebDriver);
        private Label AccountNotFoundAlertLabel => new Label("Account not found alert", By.Id("message-id"), WebDriver);

        public LoginForm TypeEmail(string email)
        {
            EmailTextBox.TypeText(email);
            return this;
        }

        public LoginForm TypePassword(string password)
        {
            PasswordTextBox.TypeText(password);
            return this;
        }

        public void ClickLogin() => LoginButton.Click();

        public bool IsLoginButtonPresent() => LoginButton.IsPresent();

        public string GetTextFromAlert() => AccountNotFoundAlertLabel.Text();
    }
}