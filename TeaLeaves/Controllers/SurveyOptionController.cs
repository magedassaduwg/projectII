using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    public class SurveyOptionController
    {
        private SurveyOptionDAL _surveyOptionDAL;

        /// <summary>
        /// The constructor for the EventResponsibilityController
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
        public List<SurveyOption> GetSurveyOptionByEventId(int Id)
        {
            return _surveyOptionDAL.GetSurveyOptionByEventId(Id);
        }
    }
}
