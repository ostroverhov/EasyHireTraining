using FluentAssertions;
using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;

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
            _jobDescriptionPage.IsPagePresent().Should().BeTrue("Job description page should be present");
        }
        
        [Then("job title is present")]
        public void ThenJobTitleIsPresent()
        {
            _jobDescriptionPage.IsJobTitlePresent().Should().BeTrue("Job title should be present");
        }
        
        [Then("job description is present")]
        public void ThenJobDescriptionIsPresent()
        {
            _jobDescriptionPage.IsJobDescriptionPresent().Should().BeTrue("Job description should be present");
        }
    }
}