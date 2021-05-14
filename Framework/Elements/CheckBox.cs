using OpenQA.Selenium;

namespace Framework.Elements
{
    public class CheckBox : BaseElement
    {
        public CheckBox(string name, By locator, IWebDriver webDriver) : base($"{name} {nameof(CheckBox)}", locator, webDriver)
        {
        }
    }
}