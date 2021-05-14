using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class JobDescriptionPageSteps
    {
        private readonly JobDescriptionPage _jobDescriptionPage;

        public JobDescriptionPageSteps(BrowserFactory browserFactory)
        {
            _jobDescriptionPage = new JobDescriptionPage(browserFactory.Current);
        }

        [Then("job description page is present")]
        public void ThenJobDescriptionPageIsPresent()
        {
            Assert.True(_jobDescriptionPage.IsPagePresent(), "Job description page should be present");
        }
        
        [Then("job title is present")]
        public void ThenJobTitleIsPresent()
        {
            Assert.True(_jobDescriptionPage.IsJobTitlePresent(), "Job title should be present");
        }
        
        [Then("job description is present")]
        public void ThenJobDescriptionIsPresent()
        {
            Assert.True(_jobDescriptionPage.IsJobDescriptionPresent(), "Job description should be present");
        }
    }
}