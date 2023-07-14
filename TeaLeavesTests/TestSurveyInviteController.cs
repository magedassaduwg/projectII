using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Test inviting a member to take a survey in an event
    /// </summary>
    [TestClass]
    public class TestSurveyInviteController
    {
        /// <summary>
        /// Tests inviting a member to take a survey for an event
        /// </summary>
        [TestMethod]
        public void TestSurveyInvite()
        {
            SurveyInviteController surveyInviteController = new SurveyInviteController();
            int inviteId = surveyInviteController.AddSurveyInvite(new SurveyInvite
            {
                SurveyId = 33,
                InviterId = 1,
                ReceiverId = 24,
                Answered = true,
                Id = 0
            });

            Assert.AreNotEqual(0, inviteId);
        }

        /// <summary>
        /// Deleting a survey invite
        /// </summary>
        [TestMethod]
        public void TestSurveyInviteDelete()
        {
            SurveyInviteController surveyInviteController = new SurveyInviteController();
            bool result = surveyInviteController.DeleteSurveyInvite(24, 33);
            Assert.IsTrue(result);
        }
    }
}
