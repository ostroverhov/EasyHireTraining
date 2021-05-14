using Framework.Drivers;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MainPageSteps
    {
        private readonly MainPage _mainPage;

        public MainPageSteps(BrowserFactory browserFactory)
        {
            _mainPage = new MainPage(browserFactory.Current);
        }

        [Given("main page is present")]
        public void GivenMainPageIsPresent()
        {
            Assert.True(_mainPage.IsPagePresent(), "Main page should be present");
        }

        [When("click sign up button from main page")]
        public void WhenClickSignUpButtonFromMainPage()
        {
            _mainPage.ClickSignUpButton();            
        }
        
        [When("switch to last tab")]
        public void WhenSwitchToLastTab()
        {
            BrowserFactory.SwitchToLastTab(_mainPage.WebDriver);            
        }
    }
}