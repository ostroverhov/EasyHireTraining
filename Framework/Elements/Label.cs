using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Label 
    {
        private readonly BaseElement _element;
        
        public Label(string name, By locator, IWebDriver webDriver)
        {
            _element = new BaseElement($"{name} {nameof(TextBox)}", locator, webDriver);
        }

        public string Text() => _element.Text();

        public string GetValue() => _element.GetValue();

        public bool IsDisplayed() => _element.IsDisplayed();

        public int CountElements() => _element.CountElements();

        public void ClickElementFromList(int elementNumber) => _element.ClickElementFromList(elementNumber);

        public string GetElementTextFromList(int elementNumber) => _element.GetElementTextFromList(elementNumber);
    }
}