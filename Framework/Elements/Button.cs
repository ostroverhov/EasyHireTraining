using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Button
    {
        private readonly BaseElement _element;
        
        public Button(string name, By locator, IWebDriver webDriver)
        {
            _element = new BaseElement($"{name} {nameof(Button)}", locator, webDriver);
        }

        public void Click() => _element.Click();

        public bool IsPresent() => _element.IsPresent();
    }
}