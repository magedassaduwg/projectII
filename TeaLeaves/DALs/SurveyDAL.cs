using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL class for the Survey table
    /// </summary>
    public class SurveyDAL
    {
        /// <summary>
        /// saves a survey to the database
        /// </summary>
        /// <param name="survey"></param>
        /// <returns></returns>
        public int SaveSurvey(Survey survey, List<SurveyOption> surveyOptions)
        {
            string query = survey.Id <= 0 ?
                @"INSERT INTO Events (Name, CreatorId, SurveyDateTime) 
                VALUES (@Name, @CreatorId, @SurveyDateTime)
                select scope_identity()"
                :
                @"UPDATE Events 
                SET Name = @Name, SurveyDateTime = @SurveyDateTime, CreatorId = @CreatorId 
                WHERE SurveyId = @surveyId

                select @SurveyId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (SqlCommand saveCommand = new SqlCommand(query, connection, transaction))
                {
                    saveCommand.Parameters.AddWithValue("@surveyId", survey.Id);
                    saveCommand.Parameters.AddWithValue("@Name", survey.SurveyName);
                    saveCommand.Parameters.AddWithValue("@CreatorId", survey.CreatorId);
                    saveCommand.Parameters.AddWithValue("@SurveyDateTime", survey.SurveyDateTime);

                    try
                    {
                        int lastSurvey = Convert.ToInt32(saveCommand.ExecuteScalar());

                        foreach (SurveyOption surveyOption in surveyOptions)
                        {
                            SqlCommand insertResponsibilitiesCommand = new SqlCommand("INSERT INTO SurveyOptions (SurveyId, Name, Votes) " +
                            "Values (@SurveyId, @Name, @Votes); ", connection, transaction);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@Name", surveyOption.Name);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@Votes", surveyOption.Votes);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@SurveyId", lastSurvey);
                            insertResponsibilitiesCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        return lastSurvey;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }

                }
            }
        }

        public List<Survey> GetSurveyByUserId(int userId)
        {
            List<Survey> survey = new List<Survey>();
            string query = @"SELECT SurveyId, SurveyDateTime, Name
                     FROM Surveys
                     WHERE CreatorId = @UserId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Survey @surveys = new Survey
                            {
                                Id = Convert.ToInt32(reader["SurveyId"]),
                                SurveyDateTime = Convert.ToDateTime(reader["SurveyDateTime"]),
                                SurveyName = reader["Name"].ToString(),

                            };

                            survey.Add(surveys);
                        }
                    }
                }
            }

            return survey;
        }
    }
}
