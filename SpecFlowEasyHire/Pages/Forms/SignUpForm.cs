using Framework.Elements;
using OpenQA.Selenium;
using SpecFlowEasyHire.Enums;
using System.Collections.Generic;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class SignUpForm: BasePage
    {
        public SignUpForm(IWebDriver webDriver) : base(nameof(SignUpForm), By.CssSelector("header.MuiPaper-root"), webDriver)
        {
        }
        
        private Button AccountButton(AccountTypeItem item) => 
            new Button($"Account type [{item}]", By.XPath($"//span[contains(text(), '{AccountTypeButton[item]}') and @class='MuiTab-wrapper']"), WebDriver);
        private TextBox EmailTextBox => new TextBox("Email", By.Name("email"), WebDriver);
        private TextBox FirstNameTextBox => new TextBox("First name", By.Name("firstName"), WebDriver);
        private TextBox LastNameTextBox => new TextBox("Last name", By.Name("lastName"), WebDriver);
        private TextBox PasswordTextBox => new TextBox("Password", By.Name("password"), WebDriver);
        private CheckBox TermsAndConditionsCheckBox => new CheckBox("Terms and conditions", By.Name("termAgree"), WebDriver);
        private Label SignUpAlertLabel => new Label("Sign Up", By.Id("message-id"), WebDriver);
        private Button SignUpButton => new Button("Sign Up",
            By.XPath("//button//span[@class='MuiTouchRipple-root']/preceding-sibling::span[contains(text(), 'Sign up')]"), WebDriver);
        
        private IDictionary<AccountTypeItem, string> AccountTypeButton => new Dictionary<AccountTypeItem, string>
        {
            { AccountTypeItem.HiringManager, "Hiring manager"},
            { AccountTypeItem.Applicant, "Applicant"}
        };

        public void SelectAccountType(AccountTypeItem item) => AccountButton(item).Click();

        public SignUpForm TypeEmail(string email)
        {
            EmailTextBox.TypeText(email);
            return this; 
        }
        
        public SignUpForm TypeFirstName(string firstName)
        {
            FirstNameTextBox.TypeText(firstName);
            return this; 
        }
        
        public SignUpForm TypeLastName(string lastName)
        {
            LastNameTextBox.TypeText(lastName);
            return this; 
        }
        
        public SignUpForm TypePassword(string password)
        {
            PasswordTextBox.TypeText(password);
            return this; 
        }

        public void ClickTermsAndConditionsCheckBox() => TermsAndConditionsCheckBox.Click();

        public void ClickSignUpButton() => SignUpButton.Click();

        public bool IsSignUpButtonPresent() => SignUpButton.IsPresent();

        public string GetTextFromSignUpAlert() => SignUpAlertLabel.Text();
    }
}