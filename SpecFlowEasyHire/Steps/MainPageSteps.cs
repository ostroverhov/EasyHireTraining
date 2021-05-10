using NUnit.Framework;
using SpecFlowEasyHire.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps
{
    [Binding]
    public sealed class MainPageSteps
    {
        private readonly MainPage _mainPage;

        public MainPageSteps(MainPage mainPage)
        {
            _mainPage = mainPage;
        }

        [Given("main page is present")]
        public void GivenMainPageIsPresent()
        {
            Assert.IsTrue(_mainPage.IsPagePresent(), "Main page should be present");
        }

        [When("click sign up button from main page")]
        public void WhenClickSignUpButtonFromMainPage()
        {
            _mainPage.ClickSignUpButton();            
        }
    }
}