using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Test Class for the SurveyVote controller
    /// </summary>
    [TestClass]
    public class TestSurveyVoteController
    {
        /// <summary>
        /// Tests the SaveVote and DeleteVote methods
        /// </summary>
        [TestMethod]
        public void TestSaveVoteAndDeleteVote()
        {
            SurveyVoteController controller = new SurveyVoteController();
            SurveyVote surveyVote = new SurveyVote
            {
                SurveyId = 31,
                SurveyOptionId = 42,
                UserId = 25,
            };

            try
            {
                int surveyVoteId = controller.SaveVote(surveyVote);
                Assert.AreNotEqual(surveyVoteId, 0);

                controller.DeleteVote(surveyVoteId);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetSurveyVoteBySurveyIdAndUserId method
        /// </summary>
        [TestMethod]
        public void GetSurveyVoteBySurveyIdAndUserId()
        {
            SurveyVoteController controller = new SurveyVoteController();

            try
            {
                SurveyVote surveyVote = controller.GetSurveyVoteBySurveyIdAndUserId(32, 25);
                Assert.AreEqual(surveyVote.Id, 21);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
