using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FirstPOMProject.Utilities
{
    public class SeleniumActions
    {

        private IWebDriver webDriver;
        public SeleniumActions(IWebDriver Webdriver)
        {
            webDriver = Webdriver;
        }
        public void Click(By locator)
        {
            IWebElement element = webDriver.FindElement(locator);
            element.Click();
        }
        public string GetText(IWebElement element)
        {
            //  IWebElement element = webDriver.FindElement(locator);
            return element.Text;
        }
        public void TypeText(By locator, String text)
        {
            IWebElement element = webDriver.FindElement(locator);
            element.Click();
            element.SendKeys(text);
        }
        public void selectdropdown(By locator, String text)
        {
            IWebElement element = webDriver.FindElement(locator);
            var selectdropdownoptions = new SelectElement(element);
            selectdropdownoptions.SelectByText(text);
        }
    }
}
