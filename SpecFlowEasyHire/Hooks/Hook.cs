using System;
using Framework.Drivers;
using Framework.Utils;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Hooks
{
    [Binding]
    public class Hooks
    {
        private static Logger Logger => Logger.Instance;
        
        [BeforeScenario("web")]
        public static void BeforeScenario()
        {
            Logger.Info($"{new string('=', 100)} {Environment.NewLine} {new string(' ', 40)} Start scenario");
            BrowserFactory.InitBrowser();
            BrowserFactory.SetMaxSizeWindow();
            BrowserFactory.SetImplicitlyWait();
            BrowserFactory.SetUrl();
        }
        
        [AfterScenario("web")]
        public static void AfterScenario()
        {
            BrowserFactory.CloseBrowser();
            Logger.Info($"{Environment.NewLine} {new string(' ', 40)} Scenario completed!");
        }
    }
}