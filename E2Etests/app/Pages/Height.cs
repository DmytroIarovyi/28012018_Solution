using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class Height : Waiters
    {
        public Height FillHeightWith(int height)
        {
            driver.FindElement(By.CssSelector("input.css-a97dg0")).SendKeys(height.ToString());
            WaitUntilElementIsVisible("div.css-1b6mtdb");
            return this;
        }

        public void ClickNextButton()
        {
            driver.FindElement(By.CssSelector("div.css-1b6mtdb")).Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }
    }
}
