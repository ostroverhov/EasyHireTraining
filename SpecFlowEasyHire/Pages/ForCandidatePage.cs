using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class ForCandidatePage: BasePage
    {
        public ForCandidatePage(IWebDriver webDriver) : base(nameof(ForCandidatePage), By.CssSelector(".vjs-tech"), webDriver)
        {
        }

        private Button TakeInterviewButton => new Button("Take Interview", By.CssSelector("[href*=request_practice]"), WebDriver);
        private ComboBox SelectLanguageComboBox => new ComboBox("Select language",
            By.XPath(
                "//label[contains(text(), 'Select language')]/following-sibling::div//input"), WebDriver);
        private ComboBox SelectQuestionCategoryComboBox => new ComboBox("Select question category",
            By.XPath(
                "//label[contains(text(), 'Select question category')]/following-sibling::div//input"), WebDriver);
        private Label ComboBoxItemLabel => new Label("ComboBox item",
            By.CssSelector("[role=option]"), WebDriver);

        private Button TakeInterviewButtonOnPanel => new Button("Take interview on panel",
            By.XPath("//button//span[contains(text(), 'Take practice interview')] "), WebDriver);
        public void ClickTakeInterviewButton() => TakeInterviewButton.Click();

        public void ClickTakeInterviewOnPanel() => TakeInterviewButtonOnPanel.Click();
        
        public void ClickSelectLanguageComboBox() => SelectLanguageComboBox.Click();

        public void ClickSelectQuestionCategoryComboBox() => SelectQuestionCategoryComboBox.Click();

        public void ClickComboBoxItem(int item) => ComboBoxItemLabel.ClickElementFromList(item);

        public int SizeComboBox() => ComboBoxItemLabel.CountElements();
    }
}