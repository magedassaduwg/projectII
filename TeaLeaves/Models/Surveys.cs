using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaLeaves.Models
{
    public class Surveys
    {
        public string? SurveyName { get; set; }
        public DateTime SurveyDateTime { get; set; }
        public int CreatorId { get; set; }
        public int SurveyId { get; set; }
    }
}
