using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Elements
{
    public class ComboBox : BaseElement
    {
        public ComboBox(string name, By locator) : base($"{name} {nameof(ComboBox)}", locator)
        {
        }

        public void SelectByValue(string value) => new SelectElement(GetElement()).SelectByValue(value);
        
        public void SelectByText(string text) => new SelectElement(GetElement()).SelectByText(text);
    }
}