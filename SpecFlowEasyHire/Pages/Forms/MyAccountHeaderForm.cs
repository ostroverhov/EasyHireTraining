using System.Collections.Generic;
using Framework.Elements;
using OpenQA.Selenium;
using SpecFlowEasyHire.Enums;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class MyAccountHeaderForm: BasePage
    {
        public MyAccountHeaderForm(IWebDriver webDriver) : base(nameof(MyAccountHeaderForm), By.CssSelector("div.Header-buttonsWrap-28"), webDriver)
        {
        }

        private Button MenuButton => new Button("Menu", By.CssSelector("[aria-label=Menu] > span.MuiIconButton-label"), WebDriver);
        private Label SideMenuLabel => new Label("Side menu", By.CssSelector("[role=menu]"), WebDriver);
        private Button SideMenuButton(SideMenuItem item) => new Button($"Side menu button [{item}]", 
            By.XPath($"//ul[@role='menu']//*[contains(text(), '{SideMenuButtons[item]}')]"), WebDriver);
        private Label UserProfileLabel => new Label("User profile", By.CssSelector("[class*='(CurrentUserProfile)-main']"), WebDriver);
        private Label FirstNameLabel => new Label("First name", By.CssSelector("[name='name.first']"), WebDriver);
        private Label LastNameLabel => new Label("Last name", By.CssSelector("[name='name.last']"), WebDriver);
        private Label EmailLabel => new Label("Email", By.CssSelector("[name='email']"), WebDriver);
        
        private IDictionary<SideMenuItem, string> SideMenuButtons => new Dictionary<SideMenuItem, string>
        {
            { SideMenuItem.Settings, "Settings"},
            { SideMenuItem.Teams, "Teams"},
            { SideMenuItem.Language, "Language"},
            { SideMenuItem.ConnectivityTest, "Connectivity test"},
            { SideMenuItem.InviteUsers, "Invite users"},
            { SideMenuItem.Support, "Support"},
            { SideMenuItem.Feedback, "Feedback"},
            { SideMenuItem.LogOut, "Log out"}
        };
        
        public void ClickMenuButton() => MenuButton.Click();

        public bool IsSideMenuPresent() => SideMenuLabel.IsDisplayed();

        public void ClickSideMenuButton(SideMenuItem item) => SideMenuButton(item).Click();

        public bool IsUserProfilePresent() => UserProfileLabel.IsDisplayed();

        public string GetValueFromFirstNameLabel => FirstNameLabel.GetValue();
        
        public string GetValueFromLastNameLabel => LastNameLabel.GetValue();
        
        public string GetValueFromEmailLabel => EmailLabel.GetValue();
    }
}