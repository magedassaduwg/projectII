
using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// The controller that interacts with the SurveyDAL
    /// </summary>
    public class SurveyController
    {
        private SurveyDAL _surveyDAL;

        /// <summary>
        /// Constructor to initialize the DAL access
        /// </summary>
        public SurveyController()
        {
            _surveyDAL = new SurveyDAL();
        }
        /// <summary>
        /// Get survey by user Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Survey> GetSurveyByUserId(int userId)
        {
            return _surveyDAL.GetSurveyByUserId(userId);
        }
        /// <summary>
        /// Save the survey
        /// </summary>
        /// <param name="survey"></param>
        /// <param name="surveyOption"></param>
        /// <returns></returns>
        public int SaveSurvey(Survey @survey, List<SurveyOption> surveyOption)
        {
            return _surveyDAL.SaveSurvey(@survey, surveyOption);
        }
        /// <summary>
        /// Delete the survey
        /// </summary>
        /// <param name="surveyId"></param>
        /// <returns></returns>
        public bool DeleteSurvey(int surveyId)
        {
            return _surveyDAL.DeleteSurvey(surveyId);
        }
    }
}
