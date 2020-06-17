using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using TechTalk.SpecFlow;

namespace FirstPOMProject.Tests.Hooks.TestRunHooks
{
    [Binding]
    public class BeforeTestRunHooks
    {
        FeatureContext _featureContext;
        ScenarioContext _scenarioContext;
        public TestContext TestContext { get; set; }

        public IWebDriver driver;

        public BeforeTestRunHooks(ScenarioContext scenarioContext, FeatureContext featureContext, TestContext testContext)
        {
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public  void initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            var url = ConfigurationManager.AppSettings["Appurl"];
            driver.Navigate().GoToUrl(url);
            Console.WriteLine($"**************************** SCENARIO ------ {_scenarioContext.ScenarioInfo.Title} ******************");

            _scenarioContext.Set(driver, $"driver_App_session");
        }

        [AfterScenario]
        public  void cleanup()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();


        }
    }
}
