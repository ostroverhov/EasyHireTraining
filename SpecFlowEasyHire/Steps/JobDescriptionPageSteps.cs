using Xunit;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class JobDescriptionPageSteps
    {
        private readonly JobDescriptionPage _jobDescriptionPage;
        private readonly ScenarioContext _scenarioContext;

        public JobDescriptionPageSteps(JobDescriptionPage jobDescriptionPage, ScenarioContext scenarioContext)
        {
            _jobDescriptionPage = jobDescriptionPage;
            _scenarioContext = scenarioContext;
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