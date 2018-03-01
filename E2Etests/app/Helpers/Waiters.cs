using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace E2Etests.app.Helpers
{
    public class Waiters : DriverConfiguration
    {
        WebDriverWait GetFluentWait()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        }

        public void WaitUntilElementIsVisible(string Element)
        {
            GetFluentWait().Until(ExpectedConditions.ElementIsVisible(By.CssSelector(Element)));
        }
    }
}
