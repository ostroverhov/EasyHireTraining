using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class TakeInterviewForm : BasePage
    {
        public TakeInterviewForm() : base(nameof(TakeInterviewForm), By.CssSelector("div.MuiDialog-container"))
        {
        }

        private ComboBox SelectLanguageComboBox => new ComboBox("Select language",
            By.XPath(
                "//div[contains(@class, 'MuiDialog-container')]//label[contains(text(), 'Select language')]/following-sibling::div//input"));
        private ComboBox SelectQuestionCategoryComboBox => new ComboBox("Select question category",
            By.XPath(
                "//div[contains(@class, 'MuiDialog-container')]//label[contains(text(), 'Select question category')]/following-sibling::div//input"));
        private Label ComboBoxItemLabel => new Label($"ComboBox item",
            By.CssSelector("[role=option]"));
        private TextBox EmailTextBox => new TextBox("Email", By.Name("email"));
        private CheckBox TermsAndConditionsCheckBox => new CheckBox("Terms and conditions", By.Name("termAgree"));
        private Label TakeInterviewAlertLabel => new Label("Take interview alert", By.Id("message-id"));

        private Button ContinueButton => new Button("Continue",
            By.XPath(
                "//button//span[@class='MuiTouchRipple-root']/preceding-sibling::span[contains(text(), 'Continue')]"));

        private Button RequestInterviewButton => new Button("Request practice interview",
            By.XPath(
                "//button//span[@class='MuiTouchRipple-root']/preceding-sibling::span[contains(text(), 'Request practice interview')]"));
        
        public void ClickSelectLanguageComboBox() => SelectLanguageComboBox.Click();

        public void ClickSelectQuestionCategoryComboBox() => SelectQuestionCategoryComboBox.Click();

        public void ClickComboBoxItem(int item) => ComboBoxItemLabel.ClickElementFromList(item);

        public int SizeComboBox() => ComboBoxItemLabel.CountElements();

        public void TypeEmail(string email) => EmailTextBox.TypeText(email);

        public void ClickTermsAndConditionsCheckBox() => TermsAndConditionsCheckBox.Click();

        public void ClickContinueButton() => ContinueButton.Click();

        public void ClickRequestPracticeInterview() => RequestInterviewButton.Click();

        public string GetTextFromTakeInterviewAlert() => TakeInterviewAlertLabel.Text();
    }
}