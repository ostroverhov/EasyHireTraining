using Framework.Drivers;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MyAccountSideBarSteps
    {
        private readonly MyAccountSideBar _myAccountSideBar;

        public MyAccountSideBarSteps(BrowserFactory browserFactory)
        {
            _myAccountSideBar = new MyAccountSideBar(browserFactory.Current);
        }

        [Then("my account side bar should be presented")]
        public void ThenMyAccountSideBarShouldBePresented()
        {
            Assert.True(_myAccountSideBar.IsPagePresent(), "My account side bar should be presented");
        }
    }
}