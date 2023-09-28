using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BlueSkyCitadel.Hooks
{
    [Binding]
    public class WebHook
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}