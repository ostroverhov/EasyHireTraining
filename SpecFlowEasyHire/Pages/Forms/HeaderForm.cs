using System.Collections.Generic;
using Framework.Elements;
using OpenQA.Selenium;

namespace SpecFlowEasyHire.Pages.Forms
{
    public class HeaderForm : BasePage
    {
        public HeaderForm() : base(nameof(HeaderForm), By.CssSelector("[alt=logo]"))
        {
        }

        private Label LogoLabel => new Label("Logo", By.CssSelector("[alt=logo]"));
        private Button HeaderButton(HeaderButtonItem item) => 
            new Button($"Header button [{item}]", By.XPath($"//span[contains(text(), '{NameHeaderButton[item]}') and @class='MuiButton-label']"));
        
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
        
        public enum HeaderButtonItem
        {
            Pricing,
            JobBoard,
            Demo,
            ForCandidate,
            Blog,
            AboutUs,
            LogIn
        }
    }
}