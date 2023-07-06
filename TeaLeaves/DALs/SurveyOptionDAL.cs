using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    public class SurveyOptionDAL
    {
        public List<SurveyOption> GetSurveyOptionByEventId(int id)
        {
            List<SurveyOption> surveyOptions = new List<SurveyOption>();
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT SurveyOptionId, SurveyId, Name, Votes, VoterId
                         FROM SurveyOptions
                         WHERE SurveyId = @id;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SurveyOption surveyOption = new SurveyOption
                    {
                        SurveyOptionId = Convert.ToInt32(reader["SurveyOptionId"]),
                        SurveyId = Convert.ToInt32(reader["SurveyId"]),
                        Name = reader["Name"].ToString(),
                        Votes = Convert.ToInt32(reader["Votes"]),
                        VoterId = Convert.ToInt32(reader["VoterId"])
                    };
                    surveyOptions.Add(surveyOption);
                }
            }
            return surveyOptions;
        }
    }
      
}
