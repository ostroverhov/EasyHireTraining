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
        public static void BeforeScenario(BrowserFactory browserFactory)
        {
            Logger.Info($"{new string('=', 100)} {Environment.NewLine} {new string(' ', 40)} Start scenario");
            BrowserFactory.SetMaxSizeWindow(browserFactory.Current);
            BrowserFactory.SetImplicitlyWait(browserFactory.Current);
            BrowserFactory.SetUrl(browserFactory.Current);
        }
        
        [AfterScenario("web")]
        public static void AfterScenario(BrowserFactory browserFactory)
        {
            BrowserFactory.CloseBrowser(browserFactory.Current);
            Logger.Info($"{Environment.NewLine} {new string(' ', 40)} Scenario completed!");
        }
    }
}