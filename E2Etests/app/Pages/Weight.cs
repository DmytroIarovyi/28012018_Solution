using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class Weight : Waiters
    {
        public Weight FillWeightWith(int weight)
        {
            driver.FindElement(By.CssSelector("input.css-a97dg0")).SendKeys(weight.ToString());
            WaitUntilElementIsVisible("div.css-11r9qga");
            return this;
        }

        public void ClickNextButton()
        {
            driver.FindElement(By.CssSelector("div.css-11r9qga")).Click();
            WaitUntilElementIsVisible("p.css-1p8als0");
        }
    }
}
