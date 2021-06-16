using FluentAssertions;
using Framework.Drivers;
using SpecFlowEasyHire.Models;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginForm _loginForm;

        public LoginSteps(BrowserFactory browserFactory)
        {
            _loginForm = new LoginForm(browserFactory.Current);
        }

        [Then("login form should be presented")]
        public void ThenLoginFormShouldBePresented()
        {
            _loginForm.IsPagePresent().Should().BeTrue("Login form should be presented");
        }

        [When("type login data")]
        public void WhenTypeLoginData(LoginUser loginUser)
        {
            _loginForm.TypeEmail(loginUser.Email)
                .TypePassword(loginUser.Password);
        }

        [When("click Login button")]
        public void WhenClickLoginButton()
        {
            _loginForm.ClickLogin();
        }
        
        [Then("login button is not active")]
        public void ThenLoginButtonIsNotActive()
        {
            _loginForm.IsLoginButtonPresent().Should().BeFalse("Login button should not be active");
        }
        
        [Then("check account not found alert message")]
        public void ThenCheckAccountNotFoundAlertMessage()
        {
            _loginForm.GetTextFromAlert().Should().Contain("Account not found. Please sign up"); 
        }
    }
}