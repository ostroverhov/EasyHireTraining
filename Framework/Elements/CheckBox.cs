using OpenQA.Selenium;

namespace Framework.Elements
{
    public class CheckBox 
    {
        private readonly BaseElement _element;
        
        public CheckBox(string name, By locator, IWebDriver webDriver)
        {
            _element = new BaseElement($"{name} {nameof(CheckBox)}", locator, webDriver);
        }

        public void Click() => _element.Click();

        public bool IsSelected() => _element.IsSelected();
    }
}