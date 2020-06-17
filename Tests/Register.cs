using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstPOMProject.Pages;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace FirstPOMProject
{
    public class Register 
    {
        IWebDriver _driver;

        HomePage homePage ;
        SigninPage signInPage ;
        RegisterPage registerpage ;

        private string randomEmailId = "testing" + new Random().Next(1, 1000) + "@test.com";
       

        public Register(IWebDriver driver)
        {
            _driver = driver;
            homePage = new HomePage(_driver);
            signInPage = new SigninPage(_driver);
            registerpage = new RegisterPage(_driver);
        }

        public void SignInToApplication()
        {
            homePage.ClickSignin();
            
        }
        public void CreateAccount()
        {
            signInPage.CreateAccount(randomEmailId);
        }
        public void FillRegistraionForm()
        {
            registerpage.FillRegistrationForm();
        }

        //public void VerifyRegisteration()
        //{
        //    var randomemailid = "testing" + new Random().Next(1, 1000) + "@test.com";
        //    homePage = new HomePage(driver);
        //    signInPage= new SigninPage(driver);
        //    registerpage = new RegisterPage(driver);
        //    homePage.ClickSignin();
        //    Thread.Sleep(5000);
        //    signInPage.CreateAccount(randomemailid);
        //    Thread.Sleep(5000);
        //    registerpage.FillRegistrationForm();
        //    Thread.Sleep(5000);
        //}
    }
}
