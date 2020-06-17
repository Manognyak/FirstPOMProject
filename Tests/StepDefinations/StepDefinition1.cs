using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FirstPOMProject.Tests.StepDefinations
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private Register registerPage;
        private string KEY_WEBDRIVER = "driver_App_session";

        IWebDriver driver;

        public StepDefinition1(ScenarioContext injectedContext)
        {
            _scenarioContext = injectedContext;
            driver = _scenarioContext.Get<IWebDriver>(KEY_WEBDRIVER);
        }

        [StepDefinition(@"I sign in to the app homepage")]
        public void GivenISignInToTheAppHomepage()
        {
            registerPage = new Register(driver);
            registerPage.SignInToApplication();
        }


        [StepDefinition(@"I created account using emailId '(.*)'")]
        public void GivenICreatedAccountUsingEmailId(string emailId)
        {
            registerPage = new Register(driver);
            registerPage.CreateAccount();// parameterize it later
        }


        [StepDefinition(@"I register the user")]
        public void ThenIRegisterTheUser()
        {
            registerPage = new Register(driver);
            registerPage.FillRegistraionForm();
        }

    }
}
