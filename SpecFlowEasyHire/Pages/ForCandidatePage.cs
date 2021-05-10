using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class ForCandidatePage: BasePage
    {
        public ForCandidatePage() : base(nameof(ForCandidatePage), By.CssSelector(".vjs-tech"))
        {
        }

        private Button TakeInterviewButton => new Button("Take Interview", By.CssSelector("[href*=request_practice]"));
        private ComboBox SelectLanguageComboBox => new ComboBox("Select language",
            By.XPath(
                "//label[contains(text(), 'Select language')]/following-sibling::div//input"));
        private ComboBox SelectQuestionCategoryComboBox => new ComboBox("Select question category",
            By.XPath(
                "//label[contains(text(), 'Select question category')]/following-sibling::div//input"));
        private Label ComboBoxItemLabel => new Label($"ComboBox item",
            By.CssSelector("[role=option]"));

        private Button TakeInterviewButtonOnPanel => new Button("Take interview on panel",
            By.XPath("//button//span[contains(text(), 'Take practice interview')] "));
        public void ClickTakeInterviewButton() => TakeInterviewButton.Click();

        public void ClickTakeInterviewOnPanel() => TakeInterviewButtonOnPanel.Click();
        
        public void ClickSelectLanguageComboBox() => SelectLanguageComboBox.Click();

        public void ClickSelectQuestionCategoryComboBox() => SelectQuestionCategoryComboBox.Click();

        public void ClickComboBoxItem(int item) => ComboBoxItemLabel.ClickElementFromList(item);

        public int SizeComboBox() => ComboBoxItemLabel.CountElements();
    }
}