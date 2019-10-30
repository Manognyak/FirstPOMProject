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
    public class RegisterPage

    {
        public IWebDriver driver;
        private SeleniumActions seleniumactions;
        public RegisterPage(IWebDriver webdriver)
        {
            driver = webdriver;
            seleniumactions = new SeleniumActions(driver);
        }
        By title_Mr = By.Id("uniform-id_gender1");
        By title_Mrs = By.Id("uniform-id_gender2");
        By firstName = By.Id("customer_firstname");
        By lastName = By.Id("customer_lastname");
        By email = By.Id("email");
        By password = By.Id("passwd");
        By days = By.Id("days");
        By months = By.Id("months");
        By years = By.Id("years");
        By Signupfornews = By.Id("newsletter");
        By receivespecialoffer = By.Id("optin");
        By addrfirstName = By.Id("firstname");
        By addrlastName = By.Id("lastname");
        By company = By.Id("company");
        By address = By.Id("address1");
        By addressline2 = By.Id("address2");
        By city = By.Id("city");
        By state = By.Id("id_state");
        By zip = By.Id("postcode");
        By country = By.Id("id_country");
        By additionalinfo = By.Id("other");
        By homephone = By.Id("phone");
        By mobilephone = By.Id("phone_mobile");
        By addralias = By.Id("alias");


        public void FillRegistrationForm()
        {
            seleniumactions.Click(title_Mr);
            seleniumactions.TypeText(firstName,"FirstName");
            seleniumactions.TypeText(lastName, "LastName" );
            seleniumactions.TypeText(password, "P@ssword01");

            //    By firstName = By.Id("customer_firstname");
            //  By lastName = By.Id("customer_lastname");
          //  By email = By.Id("email");
           // By password = By.Id("passwd");
            By days = By.Id("days");
            By months = By.Id("months");
            By years = By.Id("years");
            By Signupfornews = By.Id("newsletter");
            By receivespecialoffer = By.Id("optin");
            By addrfirstName = By.Id("firstname");
            By addrlastName = By.Id("lastname");
            By company = By.Id("company");
            By address = By.Id("address1");
            By addressline2 = By.Id("address2");
            By city = By.Id("city");
            By state = By.Id("id_state");
            By zip = By.Id("postcode");
            By country = By.Id("id_country");
            By additionalinfo = By.Id("other");
            By homephone = By.Id("phone");
            By mobilephone = By.Id("phone_mobile");
            By addralias = By.Id("alias");






        }

    }
}
