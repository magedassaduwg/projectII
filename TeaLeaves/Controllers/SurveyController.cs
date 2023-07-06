using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
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
        public List<Survey> GetSurveyByUserId(int userId)
        {
            return _surveyDAL.GetSurveyByUserId(userId);
        }

        public int SaveSurvey(Survey @survey, List<SurveyOption> surveyOption)
        {
            return _surveyDAL.SaveSurvey(@survey, surveyOption);
        }
    }
}
