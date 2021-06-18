using FluentAssertions;
using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class JobBoardSteps
    {
        private readonly JobBoardPage _jobBoardPage;
        private readonly ScenarioContext _scenarioContext;

        public JobBoardSteps(ScenarioContext scenarioContext)
        {
            _jobBoardPage = new JobBoardPage();
            _scenarioContext = scenarioContext;
        }

        [Then("job board page is present")]
        public void ThenJobBoardPageIsPresent()
        {
            _jobBoardPage.IsPagePresent().Should().BeTrue("Job board page should be present");
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
            _jobBoardPage.GetValueFromSearchTextBox().Should().Be(_scenarioContext.Get<string>("keyWord"));
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
            _jobBoardPage.GetValueFromSearchByCountryComboBox().Should().Be(_scenarioContext.Get<string>("Country"));
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
            _jobBoardPage.GetValueFromSalaryRateComboBox().Should().Be(_scenarioContext.Get<string>("Salary"));
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
            _jobBoardPage.GetValueFromCurrencyComboBox().Should().Be(_scenarioContext.Get<string>("Currency"));
        }
    }
}