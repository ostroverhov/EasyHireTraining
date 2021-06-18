using FluentAssertions;
using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MainPageSteps
    {
        private readonly MainPage _mainPage;

        public MainPageSteps()
        {
            _mainPage = new MainPage();
        }

        [Given("main page is present")]
        public void GivenMainPageIsPresent()
        {
            _mainPage.IsPagePresent().Should().BeTrue("Main page should be present");
        }

        [When("click sign up button from main page")]
        public void WhenClickSignUpButtonFromMainPage()
        {
            _mainPage.ClickSignUpButton();            
        }
        
        [When("switch to last tab")]
        public void WhenSwitchToLastTab()
        {
            BrowserFactory.SwitchToLastTab();            
        }
    }
}