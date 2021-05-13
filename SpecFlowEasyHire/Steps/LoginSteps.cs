using System.Threading;
using Xunit;
using SpecFlowEasyHire.Models;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private readonly LoginForm _loginForm;

        public LoginSteps(LoginForm loginForm)
        {
            _loginForm = loginForm;
        }

        [Then("login form should be presented")]
        public void ThenLoginFormShouldBePresented()
        {
            Assert.True(_loginForm.IsPagePresent(), "Login form should be presented");
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
            Assert.False(_loginForm.IsLoginButtonPresent(), "Login button should not be active");
        }
        
        [Then("check account not found alert message")]
        public void ThenCheckAccountNotFoundAlertMessage()
        {
            Assert.Contains(_loginForm.GetTextFromAlert(), "Account not found. Please sign up");
        }
    }
}