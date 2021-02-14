using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace ResendMail
{
    [TestClass()]
    public class MailTests
    {
        static IWebDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(130));


        [TestMethod()]
        public void EmailsExchange()
        {
            var login = new Login();
            login.LogIn(driver, wait, "test_auto2020", "Training1919", "https://mail.ru/");
            var writeNewMail = new WriteNewMail();
            writeNewMail.WriteEmail(wait);
            var checkincomeletter = new CheckIncomeLetter();
            checkincomeletter.LogIn2(driver, wait, "secondmail20", "Training2020", "https://mail.ru/");
            var responseEmail = new ResponseEmail();
            responseEmail.ResponseLetter(wait);
            var login2 = new Login();
            login.LogIn(driver, wait, "test_auto2020", "Training1919", "https://mail.ru/");
            var checkFinalMail = new CheckFinalMail();
           
        }
    }
}