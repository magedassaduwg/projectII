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
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<SurveyOption> GetSurveyOptionBySurveyId(int surevyId)
        {
            return _surveyOptionDAL.GetSurveyOptionBySurveyId(surevyId);
        }
    }
}
