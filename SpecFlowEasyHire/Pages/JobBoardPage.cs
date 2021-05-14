using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class JobBoardPage: BasePage
    {
        public JobBoardPage(IWebDriver webDriver) : base(nameof(JobBoardPage), By.CssSelector("[alt='Easyhire.me']"), webDriver)
        {
        }

        private Label JobDescriptionLabel => new Label("Job description", By.CssSelector("tr.MuiTableRow-root"), WebDriver);
        private TextBox JobSearchTextBox => new TextBox("Job search", By.Id("job-search"), WebDriver);
        private ComboBox SearchByCountryComboBox => new ComboBox("Search by country", 
            By.XPath("//label[contains(text(), 'Search by country')]/following-sibling::div//input"), WebDriver);
        private ComboBox SearchBySalaryRateComboBox => new ComboBox("Search by salary rate", 
            By.XPath("//label[contains(text(), 'Search by salary range')]/following-sibling::div//input"), WebDriver);
        private ComboBox CurrencyComboBox => new ComboBox("Currency", 
            By.XPath("//label[contains(text(), 'Currency')]/following-sibling::div//input"), WebDriver);
        private Label ComboBoxItemLabel => new Label("ComboBox item", By.CssSelector("[role=option] span.MuiTypography-root"), WebDriver);

        public void ClickJobDescriptionItem(int item) => JobDescriptionLabel.ClickElementFromList(item);

        public int CountJobDescriptions() => JobDescriptionLabel.CountElements();

        public void TypeSearchText(string keyWord) => JobSearchTextBox.TypeText(keyWord);

        public string GetValueFromSearchTextBox() => JobSearchTextBox.GetValue();

        public void ClickSearchByCountryComboBox() => SearchByCountryComboBox.Click();

        public string GetValueFromSearchByCountryComboBox() => SearchByCountryComboBox.GetValue();
        
        public void ClickSearchBySalaryRateComboBox() => SearchBySalaryRateComboBox.Click();

        public string GetValueFromSalaryRateComboBox() => SearchBySalaryRateComboBox.GetValue();
        
        public void ClickCurrencyComboBox() => CurrencyComboBox.Click();
        
        public string GetValueFromCurrencyComboBox() => CurrencyComboBox.GetValue();
        
        public void ClickComboBoxItem(int item) => ComboBoxItemLabel.ClickElementFromList(item);

        public string GetTextFromComboBox(int item) => ComboBoxItemLabel.GetElementTextFromList(item);
        
        public int SizeComboBox() => ComboBoxItemLabel.CountElements();
    }
}