using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(string name, By locator) : base($"{name} {nameof(Button)}", locator)
        {
        }
    }
}