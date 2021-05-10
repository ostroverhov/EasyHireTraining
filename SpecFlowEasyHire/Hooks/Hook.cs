using System;
using System.IO;
using Framework.Drivers;
using Framework.Utils;
using Humanizer;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Hooks
{
    [Binding]
    public class Hooks
    {
        private const string PageSourceFormat = ".html";
        private static string ScenarioName => TestContext.CurrentContext.Test.Name.Replace("_", string.Empty).Humanize();
        private static Logger Logger => Logger.Instance;
        
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Logger.Info($"{new string('=', 100)} {Environment.NewLine} {new string(' ', 40)} Start scenario [{ScenarioName}]");
            BrowserFactory.InitBrowser();
            BrowserFactory.SetMaxSizeWindow();
            BrowserFactory.SetImplicitlyWait();
            BrowserFactory.SetUrl();
        }
        
        [AfterScenario]
        public static void AfterScenario()
        {
            SavePageSource();
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

        private static void SavePageSource()
        {
            Logger.Info($"Save page source for [{ScenarioName}]");
            var source = ScenarioName + PageSourceFormat;
            File.WriteAllText(source, BrowserFactory.InitBrowser().PageSource);
            TestContext.AddTestAttachment(source);
        }
    }
}