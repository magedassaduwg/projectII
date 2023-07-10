using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    ///  The controller that interacts with the SurveyOptionDAL
    /// </summary>
    public class SurveyOptionController
    {
        private SurveyOptionDAL _surveyOptionDAL;

        /// <summary>
        /// The constructor for the SurveyOptionController
        /// </summary>
        public SurveyOptionController()
        {
            _surveyOptionDAL = new SurveyOptionDAL();
        }

        /// <summary>
        /// Returns a list of survey options for the given surveyId
        /// </summary>
        /// <param name="surevyId"></param>
        /// <returns></returns>
        public List<SurveyOption> GetSurveyOptionsBySurveyId(int surevyId)
        {
            return _surveyOptionDAL.GetSurveyOptionsBySurveyId(surevyId);
        }

        /// <summary>
        /// Returns the 
        /// </summary>
        /// <param name="surveyId"></param>
        /// <returns></returns>
        public SurveyOption GetSurveyOptionBySurveyOptionId(int surveyId)
        {
            return _surveyOptionDAL.GetSurveyOptionBySurveyOptionId(surveyId);
        }
    }
}
