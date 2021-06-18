using OpenQA.Selenium;

namespace Framework.Elements
{
    public class CheckBox : BaseElement
    {
        public CheckBox(string name, By locator) : base($"{name} {nameof(CheckBox)}", locator)
        {
        }
    }
}