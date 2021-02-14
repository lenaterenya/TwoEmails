using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResendMail
{
   public class WriteNewMail
    {
        public void WriteEmail(WebDriverWait wait)
        {
            IWebElement newmail = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("compose-button__wrapper")));
            newmail.Click();

            IWebElement addressee = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[15]/div[2]/div/div[1]/div[2]/div[3]/div[2]/div/div/div[1]/div/div[2]/div/div/label/div/div/input")));
            addressee.SendKeys("secondmail20@mail.ru");
            addressee.SendKeys(Keys.Return);

            IWebElement topic = wait.Until(ExpectedConditions.ElementIsVisible(By.Name("Subject")));
            topic.SendKeys("Test Email");
            topic.SendKeys(Keys.Return);

            IWebElement body = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[15]/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div[1]")));
            body.SendKeys("Hello!");
            body.SendKeys(Keys.Return);

            IWebElement send = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[15]/div[2]/div/div[2]/div[1]/span[1]")));
            send.Click();

            IWebElement close = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("button2__wrapper")));
            close.Click();

            IWebElement logout = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("PH_logoutLink")));
            logout.Click();

                       
        }


    }
}
