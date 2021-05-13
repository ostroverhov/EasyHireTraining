using Framework.Utils;
using NUnit.Framework;
using SpecFlowEasyHire.Models;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MyAccountHeaderFormSteps
    {
        private readonly MyAccountHeaderForm _myAccountHeaderForm;
        private static readonly SignUpUser TestUser = JsonReader.SetConfigModel<SignUpUser>();

        public MyAccountHeaderFormSteps(MyAccountHeaderForm myAccountHeaderForm)
        {
            _myAccountHeaderForm = myAccountHeaderForm;
        }

        [Then("my account header form should be presented")]
        public void ThenMyAccountHeaderFormShouldBePresented()
        {
            Assert.IsTrue(_myAccountHeaderForm.IsPagePresent(), "My account header form should be presented");
        }
        
        [When("click menu button on my account")]
        public void WhenClickMenuButtonOnMyAccount()
        {
            _myAccountHeaderForm.ClickMenuButton();
        }
        
        [Then("side menu on my account is present")]
        public void ThenSideMenuOnMyAccountIsPresent()
        {
            Assert.IsTrue(_myAccountHeaderForm.IsSideMenuPresent(), "Side menu should be presented");
        }
        
        [When("click button (.*) on side menu on my account")]
        public void WhenClickButtonOnSideMenuOnMyAccount(MyAccountHeaderForm.SideMenuItem item)
        {
            _myAccountHeaderForm.ClickSideMenuButton(item);
        }
        
        [Then("user profile on my account is present")]
        public void ThenUserProfileOnMyAccountIsPresent()
        {
            Assert.IsTrue(_myAccountHeaderForm.IsUserProfilePresent(), "User profile should be presented");
        }
        
        [Then("check profile information on my account")]
        public void ThenCheckProfileInformationOnMyAccount()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(TestUser.FirstName, _myAccountHeaderForm.GetValueFromFirstNameLabel, "First names should be equal");
                Assert.AreEqual(TestUser.LastName, _myAccountHeaderForm.GetValueFromLastNameLabel, "Last names should be equal");
                Assert.AreEqual(TestUser.Email, _myAccountHeaderForm.GetValueFromEmailLabel, "emails should be equal");
            });
        }
    }
}