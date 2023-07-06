using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<SurveyOption> GetSurveyOptionByEventId(int Id)
        {
            return _surveyOptionDAL.GetSurveyOptionByEventId(Id);
        }
    }
}
