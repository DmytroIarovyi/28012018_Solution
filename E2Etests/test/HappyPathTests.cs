using Microsoft.VisualStudio.TestTools.UnitTesting;
using E2Etests.test.Configuration;
using E2Etests.app.Pages;

namespace E2Etests
{
    [TestClass]
    public class HappyPathTests : BaseTest
    {
        static BaseTest baseTest;

        static SignUp signUp;
        static Gender gender;
        static Goal goal;
        static Age age;
        static Height height;
        static Weight weight;
        static CurrentBodyFat currentBodyFat;
        static TargetBodyFat targetBodyFat;
        static AllSet allSet;


        [AssemblyInitialize]
        static public void Setup(TestContext testContext)
        {
            baseTest = new BaseTest();
            baseTest.OpenHomePage();

            signUp = new SignUp();
            gender = new Gender();
            goal = new Goal();
            age = new Age();
            height = new Height();
            weight = new Weight();
            currentBodyFat = new CurrentBodyFat();
            targetBodyFat = new TargetBodyFat();
            allSet = new AllSet();
        }

        [TestCleanup]
        public void Cleanup()
        {
            baseTest.CleanUp();
        }

        [TestMethod]
        public void HappyPathTest()
        {
            signUp.ClickGetStarted();
            gender.ClickMale();
            goal.ClickLoseFat();
            age.FillAgeWith(25).ClickNextButton();
            height.FillHeightWith(175).ClickNextButton();
            weight.FillWeightWith(70).ClickNextButton();
            currentBodyFat.ClickNextButton();
            targetBodyFat.ClickNextButton();

            string lastPageText = allSet.GetTextUnderAllSet();
            string expectedText = "We've created a personalized training program for you!";
            Assert.AreEqual(expectedText, lastPageText);
        }
    }
}
