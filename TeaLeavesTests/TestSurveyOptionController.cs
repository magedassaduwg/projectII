using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Test Class for the message controller
    /// </summary>
    [TestClass]
    public class TestSurveyOptionController
    {
        /// <summary>
        /// Tests the GetSurveyOptionsBySurveyId method
        /// </summary>
        [TestMethod]
        public void TestGetSurveyOptionsBySurveyId()
        {
            SurveyOptionController surveyOptionController = new SurveyOptionController();
            List<SurveyOption> surveyOptions;
            try
            {
                surveyOptions = surveyOptionController.GetSurveyOptionsBySurveyId(31);
                Assert.AreEqual(surveyOptions[0].SurveyOptionId, 41);
                Assert.AreEqual(surveyOptions[1].SurveyOptionId, 42);
                Assert.AreEqual(surveyOptions[2].SurveyOptionId, 43);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetSurveyOptionBySurveyOptionId method
        /// </summary>
        [TestMethod]
        public void TestGetSurveyOptionBySurveyOptionId()
        {
            SurveyOptionController surveyOptionController = new SurveyOptionController();
            SurveyOption surveyOption;
            try
            {
                surveyOption = surveyOptionController.GetSurveyOptionBySurveyOptionId(42);
                Assert.AreEqual(surveyOption.Name, "test2");
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
