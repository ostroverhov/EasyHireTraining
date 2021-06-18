using FluentAssertions;
using FluentAssertions.Execution;
using Framework.Drivers;
using Framework.Utils;
using SpecFlowEasyHire.Models;
using SpecFlowEasyHire.Pages.Forms;
using System.Reflection;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MyAccountHeaderFormSteps
    {
        private readonly MyAccountHeaderForm _myAccountHeaderForm;
        private static readonly SignUpUser TestUser = JsonReader.SetConfigModel<SignUpUser>();

        public MyAccountHeaderFormSteps()
        {
            _myAccountHeaderForm = new MyAccountHeaderForm();
        }

        [Then("my account header form should be presented")]
        public void ThenMyAccountHeaderFormShouldBePresented()
        {
            _myAccountHeaderForm.IsPagePresent().Should().BeTrue("My account header form should be presented");
        }

        [When("click menu button on my account")]
        public void WhenClickMenuButtonOnMyAccount()
        {
            _myAccountHeaderForm.ClickMenuButton();
        }

        [Then("side menu on my account is present")]
        public void ThenSideMenuOnMyAccountIsPresent()
        {
            _myAccountHeaderForm.IsSideMenuPresent().Should().BeTrue("Side menu should be presented");
        }

        [When("click button (.*) on side menu on my account")]
        public void WhenClickButtonOnSideMenuOnMyAccount(MyAccountHeaderForm.SideMenuItem item)
        {
            _myAccountHeaderForm.ClickSideMenuButton(item);
        }

        [Then("user profile on my account is present")]
        public void ThenUserProfileOnMyAccountIsPresent()
        {
            _myAccountHeaderForm.IsUserProfilePresent().Should().BeTrue("User profile should be presented");
        }

        [Then("check profile information on my account")]
        public void ThenCheckProfileInformationOnMyAccount()
        {
            using (new AssertionScope())
            {
                _myAccountHeaderForm.GetValueFromFirstNameLabel.Should().Be(TestUser.FirstName);
                _myAccountHeaderForm.GetValueFromLastNameLabel.Should().Be(TestUser.LastName);
                _myAccountHeaderForm.GetValueFromEmailLabel.Should().Be(TestUser.Email);
            }
        }
    }
}