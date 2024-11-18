using TechTalk.SpecFlow;
using UtilsLayer;

namespace UserInterfaceTAF
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriverUtilities.InitializeDriver();
            WebDriverUtilities.GoToUrl("https://www.saucedemo.com");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriverUtilities.Driver.Quit();
        }
    }
}