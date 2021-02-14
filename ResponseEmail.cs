using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ResendMail
{
  public  class ResponseEmail
    {
        public void ResponseLetter(WebDriverWait wait)
        {
            IWebElement respond = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#app-canvas > div > div.application-mail > div.application-mail__overlay > div > div.portal-menu.portal-menu_pony-mode.js-shortcut > span > div.layout__main-frame > table > tbody > tr > td > div:nth-child(1) > div.portal-menu-element.portal-menu-element_reply.portal-menu-element_expanded.portal-menu-element_not-touch.portal-menu-element_pony-mode")));
            respond.Click();

            IWebElement body = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[15]/div[2]/div/div[1]/div[2]/div[3]/div[5]/div/div/div[2]/div[1]/div[1]")));
            body.SendKeys("Got Your Mail");
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
