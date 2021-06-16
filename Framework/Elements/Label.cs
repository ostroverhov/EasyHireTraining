using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Label : BaseElement
    {
        public Label(string name, By locator, IWebDriver webDriver) : base($"{name} {nameof(TextBox)}", locator, webDriver)
        {
        }
    }
}