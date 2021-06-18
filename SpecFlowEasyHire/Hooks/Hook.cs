using System;
using System.IO;
using Framework.Drivers;
using Framework.Utils;
using Humanizer;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Hooks
{
    [Binding]
    public class Hooks
    {
        private const string PageSourceFormat = ".html";
        
        private const string ScreenshotFormat = ".png";
        
        private static string ScenarioName => TestContext.CurrentContext.Test.Name.Replace("_", string.Empty).Humanize();
        
        private static Logger Logger => Logger.Instance;
        
        [BeforeScenario("web")]
        public static void BeforeScenario()
        {
            Logger.Info($"{new string('=', 100)} {Environment.NewLine} {new string(' ', 40)} Start scenario [{ScenarioName}]");
            BrowserFactory.GetDriver();
            BrowserFactory.SetMaxSizeWindow();
            BrowserFactory.SetImplicitlyWait();
            BrowserFactory.SetUrl();
        }
        
        [AfterScenario("web")]
        public static void AfterScenario()
        {
            //SavePageSource(BrowserFactory.GetDriver);
            //TakeScreenshot(BrowserFactory.GetDriver);
            BrowserFactory.CloseBrowser();
            LogTestResults();
        }
        
        private static void LogTestResults()
        {
            var testResult = TestContext.CurrentContext.Result;
            Logger.Info($"{Environment.NewLine} {new string(' ', 40)} Scenario [{ScenarioName}] result is {testResult.Outcome.Status}!");
            if (testResult.Outcome.Status != TestStatus.Passed)
            {
                Logger.Error(testResult.Message);
            }
        }

        //private static void SavePageSource(BrowserFactory browserFactory)
        //{
        //    Logger.Info($"Save page source for [{ScenarioName}]");
        //    var source = ScenarioName + PageSourceFormat;
        //    File.WriteAllText(source, browserFactory.Current.PageSource);
        //    TestContext.AddTestAttachment(source);
        //}
        
        //private static void TakeScreenshot(BrowserFactory browserFactory)
        //{
        //    Logger.Info($"Save screenshot for [{ScenarioName}]");
        //    ((ITakesScreenshot)browserFactory.Current).GetScreenshot().SaveAsFile(ScenarioName + ScreenshotFormat);
        //}
    }
}