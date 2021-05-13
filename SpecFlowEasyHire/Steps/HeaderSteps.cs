using Xunit;
using SpecFlowEasyHire.Pages.Forms;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class HeaderSteps
    {
        private readonly HeaderForm _headerForm;

        public HeaderSteps(HeaderForm headerForm)
        {
            _headerForm = headerForm;
        }

        [When("click header button (.*)")]
        public void WhenClickHeaderButton(HeaderForm.HeaderButtonItem item)
        {
            _headerForm.ClickHeaderButton(item);
        }

        [Then("header form is present")]
        public void ThenHeaderFormIsPresent()
        {
            Assert.True(_headerForm.IsPagePresent(), "Header form should be presented");
        }
    }
}