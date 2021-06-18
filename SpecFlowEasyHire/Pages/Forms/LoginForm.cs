using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class LoginForm : BasePage
    {
        public LoginForm() : base(nameof(LoginForm), By.CssSelector("header.MuiPaper-root"))
        {
        }

        private TextBox EmailTextBox => new TextBox($"Login", By.Name("email"));
        private TextBox PasswordTextBox => new TextBox("Password", By.Name("password"));
        private Button LoginButton => new Button("Login",
            By.XPath("//button//span[@class='MuiTouchRipple-root']/preceding-sibling::span[contains(text(), 'Log in')]"));
        private Label AccountNotFoundAlertLabel => new Label("Account not found alert", By.Id("message-id"));

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