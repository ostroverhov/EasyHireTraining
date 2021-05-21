using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Elements
{
    public class ComboBox 
    {
        private readonly BaseElement _element;
        
        public ComboBox(string name, By locator, IWebDriver webDriver)
        {
            _element = new BaseElement($"{name} {nameof(ComboBox)}", locator, webDriver);
        }

        public void Click() => _element.Click();

        public string GetValue() => _element.GetValue();

        public void SelectByValue(string value) => new SelectElement(_element.GetElement()).SelectByValue(value);
        
        public void SelectByText(string text) => new SelectElement(_element.GetElement()).SelectByText(text);
    }
}