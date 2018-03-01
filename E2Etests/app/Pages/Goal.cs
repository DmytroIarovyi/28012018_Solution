using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class Goal : Waiters
    {
        public void ClickLoseFat()
        {
            driver.FindElements(By.CssSelector("div.overlay.css-leiakd"))[0].Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }

        public void ClickGetFitter()
        {
            driver.FindElements(By.CssSelector("div.overlay.css-leiakd"))[1].Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }

        public void ClicGinMuscleMass()
        {
            driver.FindElements(By.CssSelector("div.overlay.css-leiakd"))[2].Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }
    }
}
