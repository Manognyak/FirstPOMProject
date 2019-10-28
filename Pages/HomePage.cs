using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using FirstPOMProject.TestSetup;
using FirstPOMProject.Utilities;

namespace FirstPOMProject.Pages
{
    public class HomePage

    { 
        public IWebDriver driver;
        private SeleniumActions seleniumactions;
        public  HomePage(IWebDriver webdriver )
        {
             driver = webdriver;
             seleniumactions = new SeleniumActions(driver);
        }
        By signin= By.LinkText("Sign in");
     
        public void ClickSignin()
        {
            seleniumactions.Click(signin);
        }

    }
}
