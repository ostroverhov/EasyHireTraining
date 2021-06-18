using System.Collections.Generic;
using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class MyAccountHeaderForm: BasePage
    {
        public MyAccountHeaderForm() : base(nameof(MyAccountHeaderForm), By.CssSelector("div.Header-buttonsWrap-28"))
        {
        }

        private Button MenuButton => new Button("Menu", By.CssSelector("[aria-label=Menu] > span.MuiIconButton-label"));
        private Label SideMenuLabel => new Label("Side menu", By.CssSelector("[role=menu]"));
        private Button SideMenuButton(SideMenuItem item) => new Button($"Side menu button [{item}]",
            By.XPath($"//ul[@role='menu']//*[contains(text(), '{SideMenuButtons[item]}')]"));
        private Label UserProfileLabel => new Label("User profile", By.CssSelector("[class*='(CurrentUserProfile)-main']"));
        private Label FirstNameLabel => new Label("First name", By.CssSelector("[name='name.first']"));
        private Label LastNameLabel => new Label("Last name", By.CssSelector("[name='name.last']"));
        private Label EmailLabel => new Label("Email", By.CssSelector("[name='email']"));

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

        public enum SideMenuItem
        {
            Settings,
            Teams,
            Language,
            ConnectivityTest,
            InviteUsers,
            Support,
            Feedback,
            LogOut
        }
    }
}