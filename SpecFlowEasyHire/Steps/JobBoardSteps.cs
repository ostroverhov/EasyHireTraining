using System;
using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class JobBoardSteps
    {
        private readonly JobBoardPage _jobBoardPage;
        private readonly ScenarioContext _scenarioContext;

        public JobBoardSteps(BrowserFactory browserFactory, ScenarioContext scenarioContext)
        {
            _jobBoardPage = new JobBoardPage(browserFactory.Current);
            _scenarioContext = scenarioContext;
        }

        [Then("job board page is present")]
        public void ThenJobBoardPageIsPresent()
        {
            Assert.True(_jobBoardPage.IsPagePresent(), "Job board page should be present");
        }

        [When("click random job label")]
        public void WhenClickRandomJobLabel()
        {
            _jobBoardPage.ClickJobDescriptionItem(new Random().Next(_jobBoardPage.CountJobDescriptions()));
        }
        
        [When("type search key word (.*)")]
        public void WhenTypeSearchKeyWord(string keyWord)
        {
            _scenarioContext.Set(keyWord, "keyWord");
            _jobBoardPage.TypeSearchText(keyWord);
        }
        
        [Then("check search key word")]
        public void ThenCheckSearchKeyWord()
        {
            Assert.Equal(_scenarioContext.Get<string>("keyWord"), _jobBoardPage.GetValueFromSearchTextBox());
        }
        
        [When("select random country")]
        public void WhenSelectRandomCountry()
        {
            _jobBoardPage.ClickSearchByCountryComboBox();
            var randomCountry = new Random().Next(_jobBoardPage.SizeComboBox());
            _scenarioContext.Set(_jobBoardPage.GetTextFromComboBox(randomCountry), "Country");
            _jobBoardPage.ClickComboBoxItem(randomCountry);
        }
        
        [Then("check select by country field")]
        public void ThenCheckSelectByCountryField()
        {
            Assert.Equal(_scenarioContext.Get<string>("Country"), _jobBoardPage.GetValueFromSearchByCountryComboBox());
        }
        
        [When("select random salary range")]
        public void WhenSelectRandomSalaryRange()
        {
            _jobBoardPage.ClickSearchBySalaryRateComboBox();
            var randomSalaryRange = new Random().Next(_jobBoardPage.SizeComboBox());
            _scenarioContext.Set(_jobBoardPage.GetTextFromComboBox(randomSalaryRange), "Salary");
            _jobBoardPage.ClickComboBoxItem(randomSalaryRange);
        }
        
        [Then("check salary range field")]
        public void ThenCheckSalaryRangeField()
        {
            Assert.Equal(_scenarioContext.Get<string>("Salary"), _jobBoardPage.GetValueFromSalaryRateComboBox());
        }
        
        [When("select random currency")]
        public void WhenSelectRandomCurrency()
        {
            _jobBoardPage.ClickCurrencyComboBox();
            var randomSalaryRange = new Random().Next(_jobBoardPage.SizeComboBox());
            _scenarioContext.Set(_jobBoardPage.GetTextFromComboBox(randomSalaryRange), "Currency");
            _jobBoardPage.ClickComboBoxItem(randomSalaryRange);
        }
        
        [Then("check currency field")]
        public void ThenCheckCurrencyField()
        {
            Assert.Equal(_scenarioContext.Get<string>("Currency"), _jobBoardPage.GetValueFromCurrencyComboBox());
        }
    }
}