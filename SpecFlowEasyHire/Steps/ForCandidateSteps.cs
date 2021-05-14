using System;
using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class ForCandidateSteps
    {
        private readonly ForCandidatePage _forCandidatePage;

        public ForCandidateSteps(BrowserFactory browserFactory)
        {
            _forCandidatePage = new ForCandidatePage(browserFactory.Current);
        }

        [Then("for candidate page should be presented")]
        public void ThenForCandidatePageShouldBePresented()
        {
            Assert.True(_forCandidatePage.IsPagePresent(), "For candidate page should be presented");
        }
        
        [When("click take practice interview button")]
        public void WhenClickTakePracticeInterviewButton()
        {
            _forCandidatePage.ClickTakeInterviewButton();
        }
        
        [When("select random interview language on 'for candidate' page")]
        public void WhenSelectRandomInterviewLanguageOnPage()
        {
            _forCandidatePage.ClickSelectLanguageComboBox();
            _forCandidatePage.ClickComboBoxItem(new Random().Next(_forCandidatePage.SizeComboBox()));
        }
        
        [When("select random question category on 'for candidate' page")]
        public void WhenSelectRandomQuestionCategoryOnPage()
        {
            _forCandidatePage.ClickSelectQuestionCategoryComboBox();
            _forCandidatePage.ClickComboBoxItem(new Random().Next(_forCandidatePage.SizeComboBox()));
        }
        
        [When("click take practice interview button on the select panel")]
        public void WhenClickTakePracticeInterviewButtonOnTheSelectPanel()
        {
            _forCandidatePage.ClickTakeInterviewOnPanel();
        }
    }
}