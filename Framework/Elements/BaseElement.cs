using System.Collections.Generic;
using Framework.Drivers;
using Framework.Utils;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public abstract class BaseElement
    {
        protected readonly string Name;
        protected readonly By Locator;
        protected static Logger Logger => Logger.Instance;

        public BaseElement(string name, By locator)
        {
            Name = name;
            Locator = locator;
        }
        
        public IWebElement GetElement() 
        {
            Logger.Info($"Get element [{Name}]");
            return BrowserFactory.InitBrowser().FindElement(Locator);
        }

        public IList<IWebElement> GetElements() 
        {
            Logger.Info($"Get list elements [{Name}]");
            return BrowserFactory.InitBrowser().FindElements(Locator);
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
    }
}