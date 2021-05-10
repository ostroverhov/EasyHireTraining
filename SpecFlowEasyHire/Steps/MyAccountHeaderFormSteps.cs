using NUnit.Framework;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MyAccountHeaderFormSteps
    {
        private readonly MyAccountHeaderForm _myAccountHeaderForm;

        public MyAccountHeaderFormSteps(MyAccountHeaderForm myAccountHeaderForm)
        {
            _myAccountHeaderForm = myAccountHeaderForm;
        }

        [Then("my account header form should be presented")]
        public void ThenMyAccountHeaderFormShouldBePresented()
        {
            Assert.IsTrue(_myAccountHeaderForm.IsPagePresent(), "My account header form should be presented");
        }
    }
}