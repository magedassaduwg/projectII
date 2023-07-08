using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL for the SurveyOptions table
    /// </summary>
    public class SurveyOptionDAL
    {
        /// <summary>
        /// Get survey option by survey id
        /// </summary>
        /// <param name="surveyId"></param>
        /// <returns></returns>
        public List<SurveyOption> GetSurveyOptionBySurveyId(int surveyId)
        {
            List<SurveyOption> surveyOptions = new List<SurveyOption>();
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT SurveyOptionId, SurveyId, Name, Votes
                         FROM SurveyOptions WHERE SurveyId = @surveyId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@surveyId", surveyId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SurveyOption surveyOption = new SurveyOption
                    {
                        SurveyOptionId = Convert.ToInt32(reader["SurveyOptionId"]),
                        SurveyId = Convert.ToInt32(reader["SurveyId"]),
                        Name = reader["Name"].ToString(),
                        Votes = Convert.ToInt32(reader["Votes"])
                    };
                    surveyOptions.Add(surveyOption);
                }
            }
            return surveyOptions;
        }
    }
      
}
