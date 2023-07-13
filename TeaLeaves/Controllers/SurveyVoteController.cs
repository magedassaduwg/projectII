using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// The controller for the SurveyVoteDAL
    /// </summary>
    public class SurveyVoteController
    {
        SurveyVoteDAL _surveyVoteDAL;

        /// <summary>
        /// The constructor for the SurveyVoteController
        /// </summary>
        public SurveyVoteController() { 
            _surveyVoteDAL = new SurveyVoteDAL();
        }

        /// <summary>
        /// Saves a new vote or updates an existing vote, and updates the vote amount for the new chosen option and the previous option
        /// </summary>
        /// <param name="surveyVote"></param>
        /// <param name="surveyOptions"></param>
        /// <returns></returns>
        public int SaveVote(SurveyVote surveyVote, List<SurveyOption> surveyOptions) {
            return _surveyVoteDAL.SaveVote(surveyVote, surveyOptions);
        }

        /// <summary>
        /// Saves a new vote or updates an existing vote, and updates the vote amount for the new chosen option and the previous option
        /// </summary>
        /// <param name="surveyVote"></param>
        /// <returns></returns>
        public int SaveVote(SurveyVote surveyVote)
        {
            return _surveyVoteDAL.SaveVote(surveyVote);
        }

        /// <summary>
        /// Returns a survey vote with the given userId and surveyId
        /// </summary>
        /// <param name="surveyId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public SurveyVote GetSurveyVoteBySurveyIdAndUserId(int surveyId, int userId)
        {
            return _surveyVoteDAL.GetSurveyVoteBySurveyIdAndUserId(surveyId, userId);
        }
    }
}
