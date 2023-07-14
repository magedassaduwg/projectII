using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// The controller for the SurveyInviteDAL
    /// </summary>
    public class SurveyInviteController
    {
        SurveyInviteDAL _surveyInviteDAL;

        /// <summary>
        /// The constructor for the SurveyInviteController class
        /// </summary>
        public SurveyInviteController()
        {
            _surveyInviteDAL = new SurveyInviteDAL();
        }

        /// <summary>
        /// Adds a survey invite to the database
        /// </summary>
        /// <param name="surveyInvite"></param>
        /// <returns></returns>
        public int AddSurveyInvite(SurveyInvite surveyInvite)
        {
            return _surveyInviteDAL.AddSurveyInvite(surveyInvite);
        }

        /// <summary>
        /// Deletes a survey invite from the database
        /// </summary>
        /// <param name="surveyReceiverId"></param>
        /// <param name="surveyId"></param>
        /// <returns></returns>
        public bool DeleteSurveyInvite(int surveyReceiverId, int surveyId)
        {
            return _surveyInviteDAL.DeleteSurveyInvite(surveyReceiverId, surveyId);
        }
    }
}
