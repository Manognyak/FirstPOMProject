using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstPOMProject.Pages;
using FirstPOMProject.TestSetup;
using System.Threading;
namespace FirstPOMProject
{
    [TestClass]
    public class Register : Setup
    {
        HomePage homePage;
        SigninPage signInPage;
        RegisterPage registerpage;
        [TestMethod]
        public void VerifyRegisteration()
        {
            var randomemailid = "testing" + new Random().Next(1, 1000) + "@test.com";
            homePage = new HomePage(driver);
            signInPage= new SigninPage(driver);
            registerpage = new RegisterPage(driver);

            homePage.ClickSignin();
            Thread.Sleep(5000);
            signInPage.CreateAccount(randomemailid);
            Thread.Sleep(5000);
            registerpage.FillRegistrationForm();
            Thread.Sleep(5000);
        }
    }
}
