using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class Gender : Waiters
    {
        public void ClickMale()
        {
            driver.FindElements(By.CssSelector("div.overlay.css-bea24r"))[0].Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }

        public void ClickFemale()
        {
            driver.FindElements(By.CssSelector("div.overlay.css-bea24r"))[1].Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }

    }
}
