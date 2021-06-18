using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Label : BaseElement
    {
        public Label(string name, By locator) : base($"{name} {nameof(TextBox)}", locator)
        {
        }
    }
}