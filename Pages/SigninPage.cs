using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FirstPOMProject.Utilities;
using System.Threading;

namespace FirstPOMProject.Pages
{
    public class SigninPage

    {
        public IWebDriver driver;
        private SeleniumActions seleniumactions;
        public SigninPage(IWebDriver webdriver)
        {
            driver = webdriver;
            seleniumactions = new SeleniumActions(driver);
        }
        By emailId = By.Id("email_create");
        By createaccountbutton = By.Id("SubmitCreate");
        public void CreateAccount(string emailid)
        {
            
            seleniumactions.TypeText(emailId, emailid);
            Thread.Sleep(500);
            seleniumactions.Click(createaccountbutton);
        }

    }
}
