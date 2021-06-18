using FluentAssertions;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MyAccountSideBarSteps
    {
        private readonly MyAccountSideBar _myAccountSideBar;

        public MyAccountSideBarSteps()
        {
            _myAccountSideBar = new MyAccountSideBar();
        }

        [Then("my account side bar should be presented")]
        public void ThenMyAccountSideBarShouldBePresented()
        {
            _myAccountSideBar.IsPagePresent().Should().BeTrue("My account side bar should be presented");
        }
    }
}