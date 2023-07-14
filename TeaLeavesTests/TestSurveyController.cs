using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// This test class will test the Survey controller with all its methods
    /// </summary>
    [TestClass]
    public class TestSurveyController
    {
        /// <summary>
        /// Tests creating a new survey with options
        /// </summary>
        [TestMethod]
        public void TestSurveyCreation()
        {
            SurveyController surveyController = new SurveyController();
            Survey survey = new Survey
            {
                CreatorId = 1,
                CreatorName = "Test Survey",
                Id = 0,
                SurveyDateTime = DateTime.Now,
                SurveyName = "Park Day"
            };

            List<SurveyOption> option = new List<SurveyOption>
            {
                new SurveyOption {
                    Name = "Favorite Food",
                    SurveyId = 0,
                    SurveyOptionId = 0,
                    Votes = 0
                }
            };

            try
            {
                int surveyId = surveyController.SaveSurvey(survey, option);
                Assert.AreNotEqual(0,surveyId);
                surveyController.DeleteSurvey(surveyId);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        /// <summary>
        /// Tests getting surveys a user has created
        /// </summary>
        [TestMethod]
        public void TestSurveyFetchByUser()
        {
            SurveyController surveyController = new SurveyController();
            List<Survey> surveys = surveyController.GetSurveyByUserId(1);

            Assert.AreNotEqual(0, surveys.Count);
        }

        /// <summary>
        /// Tests getting surveys a user is invited to
        /// </summary>
        [TestMethod]
        public void TestSurveyInvitedSurveyId()
        {
            SurveyController surveyController = new SurveyController();
            List<Survey> surveys = surveyController.GetSurveysReceivedByUserId(3);

            Assert.AreNotEqual(0, surveys.Count);
        }
    }
}
