using E2Etests.app;
using E2Etests.app.Helpers;

namespace E2Etests.test.Configuration
{
    public class BaseTest : DriverConfiguration
    {
        public void Setup()
        {
            OpenHomePage();
            driver.Manage().Window.Maximize();
        }

        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
