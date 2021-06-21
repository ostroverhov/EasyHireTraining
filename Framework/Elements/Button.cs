using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(string name, By locator, IWebDriver webDriver) : base($"{name} {nameof(Button)}", locator, webDriver)
        {
        }
    }
}
