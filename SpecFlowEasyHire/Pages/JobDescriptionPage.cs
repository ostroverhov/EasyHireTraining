using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages
{
    public class JobDescriptionPage: BasePage
    {
        public JobDescriptionPage() : base(nameof(JobDescriptionPage), By.CssSelector("[title='Explainer video tutorial']"))
        {
        }

        private Label JobTitleLabel => new Label("Job title", By.Id("job-title"));
        private Label JobDescriptionLabel => new Label("Job description", By.CssSelector("p.MuiTypography-root"));

        public bool IsJobTitlePresent() => JobTitleLabel.IsDisplayed();

        public bool IsJobDescriptionPresent() => JobDescriptionLabel.IsDisplayed();
    }
}