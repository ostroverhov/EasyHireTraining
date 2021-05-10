using NUnit.Framework;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MyAccountSideBarSteps
    {
        private readonly MyAccountSideBar _myAccountSideBar;

        public MyAccountSideBarSteps(MyAccountSideBar myAccountSideBar)
        {
            _myAccountSideBar = myAccountSideBar;
        }

        [Then("my account side bar should be presented")]
        public void ThenMyAccountSideBarShouldBePresented()
        {
            Assert.IsTrue(_myAccountSideBar.IsPagePresent(), "My account side bar should be presented");
        }
    }
}