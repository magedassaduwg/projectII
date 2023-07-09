
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
                @"INSERT INTO Surveys (Name, CreatorId, SurveyDateTime) 
                VALUES (@Name, @CreatorId, @SurveyDateTime)
                select scope_identity()"
                :
                @"UPDATE Surveys 
                SET Name = @Name, SurveyDateTime = @SurveyDateTime
                WHERE SurveyId = @surveyId

                select @SurveyId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (SqlCommand saveCommand = new SqlCommand(query, connection, transaction))
                {
                    saveCommand.Parameters.AddWithValue("@surveyId", survey.Id);
                    saveCommand.Parameters.AddWithValue("@CreatorId", survey.CreatorId);
                    saveCommand.Parameters.AddWithValue("@Name", survey.SurveyName);
                    saveCommand.Parameters.AddWithValue("@SurveyDateTime", survey.SurveyDateTime);

                    try
                    {
                        int lastSurvey = Convert.ToInt32(saveCommand.ExecuteScalar());

                        foreach (SurveyOption surveyOption in surveyOptions)
                        {
                            SqlCommand insertSurvey = new SqlCommand("INSERT INTO SurveyOptions (SurveyId, Name, Votes) " +
                            "Values (@SurveyId, @Name, @Votes); ", connection, transaction);
                            insertSurvey.Parameters.AddWithValue("@Name", surveyOption.Name);
                            insertSurvey.Parameters.AddWithValue("@Votes", surveyOption.Votes);
                            insertSurvey.Parameters.AddWithValue("@SurveyId", lastSurvey);
                            insertSurvey.ExecuteNonQuery();
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

        /// <summary>
        /// Returns all Surveys which the given user by userId has been invited to
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Survey> GetSurveysReceivedByUserId(int userId)
        {
            List<Survey> userSurveys = new List<Survey>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT s.SurveyId as UserSurveyId, CreatorId, SurveyDateTime, Name
                                    FROM Surveys s
                                    JOIN SurveyInvites si
                                    ON s.SurveyId = si.SurveyId
                                    WHERE si.SurveyReceiverId = @UserId AND si.Answered = 0;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Survey userSurvey = new Survey
                    {
                        Id = Convert.ToInt32(reader["UserSurveyId"]),
                        CreatorId = Convert.ToInt32(reader["CreatorId"]),
                        SurveyDateTime = Convert.ToDateTime(reader["SurveyDateTime"]),
                        SurveyName = reader["Name"].ToString(),
                    };
                    userSurveys.Add(userSurvey);
                }
            }
            return userSurveys;
        }

        /// <summary>
        /// Returns all Surveys which the given user by userId has been invited to
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Survey> GetAnsweredSurveysReceivedByUserId(int userId)
        {
            List<Survey> userSurveys = new List<Survey>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT s.SurveyId as UserSurveyId, CreatorId, SurveyDateTime, Name
                                    FROM Surveys s
                                    JOIN SurveyInvites si
                                    ON s.SurveyId = si.SurveyId
                                    WHERE si.SurveyReceiverId = @UserId AND si.Answered = 1;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Survey userSurvey = new Survey
                    {
                        Id = Convert.ToInt32(reader["UserSurveyId"]),
                        CreatorId = Convert.ToInt32(reader["CreatorId"]),
                        SurveyDateTime = Convert.ToDateTime(reader["SurveyDateTime"]),
                        SurveyName = reader["Name"].ToString(),
                    };
                    userSurveys.Add(userSurvey);
                }
            }
            return userSurveys;
        }

        /// <summary>
        /// Get survey bu user Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Delete  the survey
        /// </summary>
        /// <param name="surveyId"></param>
        /// <returns></returns>
        public bool DeleteSurvey(int surveyId)
        {
            string query = @"DELETE Surveys " +
                            "WHERE SurveyId = @surveyId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@surveyId", surveyId);

                    int rowsAffected = saveCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
