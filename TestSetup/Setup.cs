using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace FirstPOMProject.TestSetup
{
    public class Setup
    {
        public IWebDriver driver;

        [TestInitialize]
        public void initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            var url = ConfigurationManager.AppSettings["Appurl"];
            driver.Navigate().GoToUrl(url);
         
        }

        [TestCleanup]
        public void cleanup()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Close();


        }
    }
}
