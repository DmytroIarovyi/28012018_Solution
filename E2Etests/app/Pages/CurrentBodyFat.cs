using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class CurrentBodyFat : Waiters
    {
        public void ClickNextButton()
        {
            driver.FindElement(By.CssSelector("div.css-1b6mtdb")).Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }
    }
}
