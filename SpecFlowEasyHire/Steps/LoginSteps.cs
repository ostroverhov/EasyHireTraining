using Framework.Drivers;
using NUnit.Framework;
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
            Assert.IsTrue(_loginForm.IsPagePresent(), "Login form should be presented");
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
            Assert.IsFalse(_loginForm.IsLoginButtonPresent(), "Login button should not be active");
        }
        
        [Then("check account not found alert message")]
        public void ThenCheckAccountNotFoundAlertMessage()
        {
            StringAssert.Contains(_loginForm.GetTextFromAlert(), "Account not found. Please sign up", 
                "Alert message is not correct");
        }
    }
}