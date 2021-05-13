using NUnit.Framework;
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
            Assert.IsTrue(_jobDescriptionPage.IsPagePresent(), "Job description page should be present");
        }
        
        [Then("job title is present")]
        public void ThenJobTitleIsPresent()
        {
            Assert.IsTrue(_jobDescriptionPage.IsJobTitlePresent(), "Job title should be present");
        }
        
        [Then("job description is present")]
        public void ThenJobDescriptionIsPresent()
        {
            Assert.IsTrue(_jobDescriptionPage.IsJobDescriptionPresent(), "Job description should be present");
        }
    }
}