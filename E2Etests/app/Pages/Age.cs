using E2Etests.app.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    public class Age : Waiters
    {
        public Age FillAgeWith(int age)
        {
            driver.FindElement(By.CssSelector("input.css-a97dg0")).SendKeys(age.ToString());
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
