using OpenQA.Selenium;

namespace Framework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(string name, By locator, IWebDriver webDriver) : base($"{name} {nameof(TextBox)}", locator, webDriver)
        {
        }
        
        public void TypeText(string text) 
        {
            Logger.Info($"Type text [{text}] in element [{Name}]");
            GetElement().SendKeys(text);
        }
    }
}