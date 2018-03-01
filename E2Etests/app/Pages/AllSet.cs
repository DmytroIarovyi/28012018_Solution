using E2Etests.app.Helpers;
using OpenQA.Selenium;

namespace E2Etests.app.Pages
{
    class AllSet : Waiters
    {
        public string GetTextUnderAllSet()
        {
            return driver.FindElement(By.CssSelector("p.css-rl9p3b")).Text;
        }
    }
}
