using OpenQA.Selenium;

namespace Framework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(string name, By locator) : base($"{name} {nameof(TextBox)}", locator)
        {
        }
        
        public void TypeText(string text) 
        {
            Logger.Info($"Type text [{text}] in element [{Name}]");
            GetElement().SendKeys(text);
        }
    }
}