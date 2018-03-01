using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace E2Etests.app
{
    public class DriverConfiguration
    {
        public static IWebDriver driver = new ChromeDriver();

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://8fit.com/signup/");
        }
    }
}
