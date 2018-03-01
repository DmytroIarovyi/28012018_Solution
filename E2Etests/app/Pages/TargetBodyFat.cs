using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class TargetBodyFat : Waiters
    {
        public void ClickNextButton()
        {
            driver.FindElement(By.CssSelector("div.css-11r9qga")).Click();
            WaitUntilElementIsVisible("p.css-1gn8151");
        }
    }
}
