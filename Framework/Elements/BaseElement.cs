using System.Collections.Generic;
using Framework.Extensions;
using Framework.Utils;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public abstract class BaseElement
    {
        protected readonly string Name;
        private readonly By _locator;
        private readonly IWebDriver _webDriver;
        protected static Logger Logger => Logger.Instance;

        public BaseElement(string name, By locator, IWebDriver webDriver)
        {
            Name = name;
            _locator = locator;
            _webDriver = webDriver;
        }
        
        public IWebElement GetElement() 
        {
            Logger.Info($"Get element [{Name}]");
            return _webDriver.FindElement(_locator);
        }

        public IList<IWebElement> GetElements() 
        {
            Logger.Info($"Get list elements [{Name}]");
            return _webDriver.FindElements(_locator);
        }
        
        public bool IsDisplayed() {
            Logger.Info($"Is element [{Name}] displayed");
            return GetElement().Displayed;
        }
        
        public bool IsPresent() {
            Logger.Info($"Is element [{Name}] present");
            try {
                GetElement();
                return true;
            } catch (NoSuchElementException) {
                return false;
            }
        }
        
        public void Click() 
        {
            Logger.Info($"Click on element [{Name}]");
            GetElement().Click();
        }

        public string Text()
        {
            Logger.Info($"Get text from element [{Name}]");
            return GetElement().Text;
        }
        
        public string GetValue()
        {
            Logger.Info($"Get value from element [{Name}]");
            return GetElement().GetAttribute("value");
        }
        
        public int CountElements()
        {
            Logger.Info($"Get count of elements [{Name}]");
            return GetElements().Count;
        }
        
        public void ClickElementFromList(int elementNumber)
        {
            Logger.Info($"Click element [{elementNumber}] from List [{Name}]");
            GetElements()[elementNumber].Click();
        }
        
        public string GetElementTextFromList(int elementNumber)
        {
            Logger.Info($"Get text from element [{elementNumber}] from List [{Name}]");
            GetElements()[elementNumber].WaitForText(_webDriver);
            return GetElements()[elementNumber].Text;
        }
    }
}