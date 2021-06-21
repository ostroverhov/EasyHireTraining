using System.Collections.Generic;
using Framework.Elements;
using OpenQA.Selenium;
using SpecFlowEasyHire.Enums;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class HeaderForm : BasePage
    {
        public HeaderForm(IWebDriver webDriver) : base(nameof(HeaderForm), By.CssSelector("[alt=logo]"), webDriver)
        {
        }

        private Button HeaderButton(HeaderButtonItem item) => 
            new Button($"Header button [{item}]", By.XPath($"//span[contains(text(), '{NameHeaderButton[item]}') and @class='MuiButton-label']"), WebDriver);
        
        private IDictionary<HeaderButtonItem, string> NameHeaderButton => new Dictionary<HeaderButtonItem, string>
        {
            { HeaderButtonItem.Pricing, "Pricing"},
            { HeaderButtonItem.JobBoard, "Job board"},
            { HeaderButtonItem.Demo, "Demo"},
            { HeaderButtonItem.ForCandidate, "For candidate"},
            { HeaderButtonItem.Blog, "Blog"},
            { HeaderButtonItem.AboutUs, "About us"},
            { HeaderButtonItem.LogIn, "Log in"}
        };

        public void ClickHeaderButton(HeaderButtonItem item) => HeaderButton(item).Click();
    }
}