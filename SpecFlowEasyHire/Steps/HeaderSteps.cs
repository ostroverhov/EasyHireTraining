using Framework.Drivers;
using NUnit.Framework;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class HeaderSteps
    {
        private readonly HeaderForm _headerForm;

        public HeaderSteps(BrowserFactory browserFactory)
        {
            _headerForm = new HeaderForm(browserFactory.Current);
        }

        [When("click header button (.*)")]
        public void WhenClickHeaderButton(HeaderForm.HeaderButtonItem item)
        {
            _headerForm.ClickHeaderButton(item);
        }

        [Then("header form is present")]
        public void ThenHeaderFormIsPresent()
        {
            Assert.IsTrue(_headerForm.IsPagePresent(), "Header form should be presented");
        }
    }
}