using OpenQA.Selenium;
using E2Etests.app.Helpers;

namespace E2Etests.app.Pages
{
    public class SignUp : Waiters
    {
        public void ClickGetStarted()
        {
            driver.FindElement(By.CssSelector("div.css-1b6mtdb")).Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }
    }
}
