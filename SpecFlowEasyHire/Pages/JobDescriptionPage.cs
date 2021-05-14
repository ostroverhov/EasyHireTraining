using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class JobDescriptionPage: BasePage
    {
        public JobDescriptionPage(IWebDriver webDriver) : base(nameof(JobDescriptionPage), By.CssSelector("[title='Explainer video tutorial']"), webDriver)
        {
        }

        private Label JobTitleLabel => new Label("Job title", By.Id("job-title"), WebDriver);
        private Label JobDescriptionLabel => new Label("Job description", By.CssSelector("p.MuiTypography-root"), WebDriver);

        public bool IsJobTitlePresent() => JobTitleLabel.IsDisplayed();

        public bool IsJobDescriptionPresent() => JobDescriptionLabel.IsDisplayed();
    }
}