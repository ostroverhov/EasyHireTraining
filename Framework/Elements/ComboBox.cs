using OpenQA.Selenium;

namespace Framework.Elements
{
    public class ComboBox : BaseElement
    {
        public ComboBox(string name, By locator) : base($"{name} {nameof(ComboBox)}", locator)
        {
        }
    }
}