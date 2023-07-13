using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL for interacting with the SurveyVotes table
    /// </summary>
    public class SurveyVoteDAL
    {
        /// <summary>
        /// Saves a SurveyVote in the database with the given details
        /// </summary>
        /// <param name="surveyVote"></param>
        /// <returns></returns>
        public int SaveVote(SurveyVote surveyVote, List<SurveyOption> surveyOptions)
        {
            string query = surveyVote.Id <= 0 ?
                @"INSERT INTO SurveyVotes (SurveyId, UserId, SurveyOptionId) 
                VALUES (@SurveyId, @UserId, @SurveyOptionId)
                select scope_identity()"
                :
                @"UPDATE SurveyVotes 
                SET SurveyOptionId = @SurveyOptionId
                WHERE SurveyVoteId = @SurveyVoteId

                select @SurveyVoteId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (SqlCommand saveCommand = new SqlCommand(query, connection, transaction))
                {
                    saveCommand.Parameters.AddWithValue("@SurveyVoteId", surveyVote.Id);
                    saveCommand.Parameters.AddWithValue("@SurveyId", surveyVote.SurveyId);
                    saveCommand.Parameters.AddWithValue("@UserId", surveyVote.UserId);
                    saveCommand.Parameters.AddWithValue("@SurveyOptionId", surveyVote.SurveyOptionId);                    
                    try
                    {
                        int lastSurvey = Convert.ToInt32(saveCommand.ExecuteScalar());
                        foreach (SurveyOption surveyOption in surveyOptions)
                        {                           
                            SqlCommand insertResponsibilitiesCommand = new SqlCommand(@"UPDATE SurveyOptions SET Votes = @Votes WHERE SurveyOptionId = @SurveyOptionId", connection, transaction);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@Votes", surveyOption.Votes);
                            insertResponsibilitiesCommand.Parameters.AddWithValue("@SurveyOptionId", surveyOption.SurveyOptionId);
                            insertResponsibilitiesCommand.ExecuteNonQuery();
                        }
                        SqlCommand updateInviteCommand = new SqlCommand(@"UPDATE SurveyInvites SET Answered = 1 WHERE SurveyReceiverId = @SurveyReceiverId AND SurveyId = @SurveyId", connection, transaction);
                        updateInviteCommand.Parameters.AddWithValue("@SurveyReceiverId", surveyVote.UserId);
                        updateInviteCommand.Parameters.AddWithValue("@SurveyId", surveyVote.SurveyId);
                        updateInviteCommand.ExecuteNonQuery();
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
        /// Saves a SurveyVote in the database with the given details
        /// </summary>
        /// <param name="surveyVote"></param>
        /// <returns></returns>
        public int SaveVote(SurveyVote surveyVote)
        {
            string query = surveyVote.Id <= 0 ?
                @"INSERT INTO SurveyVotes (SurveyId, UserId, SurveyOptionId) 
                VALUES (@SurveyId, @UserId, @SurveyOptionId)
                select scope_identity()"
                :
                @"UPDATE SurveyVotes 
                SET SurveyOptionId = @SurveyOptionId
                WHERE SurveyVoteId = @SurveyVoteId

                select @SurveyVoteId";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                using (SqlCommand saveCommand = new SqlCommand(query, connection, transaction))
                {
                    saveCommand.Parameters.AddWithValue("@SurveyVoteId", surveyVote.Id);
                    saveCommand.Parameters.AddWithValue("@SurveyId", surveyVote.SurveyId);
                    saveCommand.Parameters.AddWithValue("@UserId", surveyVote.UserId);
                    saveCommand.Parameters.AddWithValue("@SurveyOptionId", surveyVote.SurveyOptionId);
                    try
                    {
                        int lastSurvey = Convert.ToInt32(saveCommand.ExecuteScalar());

                        SqlCommand insertResponsibilitiesCommand = new SqlCommand(@"UPDATE SurveyOptions SET Votes = Votes + 1 WHERE SurveyOptionId = @SurveyOptionId", connection, transaction);
                        insertResponsibilitiesCommand.Parameters.AddWithValue("@SurveyOptionId", surveyVote.SurveyOptionId);
                        insertResponsibilitiesCommand.ExecuteNonQuery();
                        SqlCommand updateInviteCommand = new SqlCommand(@"UPDATE SurveyInvites SET Answered = 1 WHERE SurveyReceiverId = @SurveyReceiverId AND SurveyId = @SurveyId", connection, transaction);
                        updateInviteCommand.Parameters.AddWithValue("@SurveyReceiverId", surveyVote.UserId);
                        updateInviteCommand.Parameters.AddWithValue("@SurveyId", surveyVote.SurveyId);
                        updateInviteCommand.ExecuteNonQuery();

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
        /// Returns a survey vote with the given userId and surveyId
        /// </summary>
        /// <param name="surveyId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public SurveyVote GetSurveyVoteBySurveyIdAndUserId(int surveyId, int userId)
        {
            SurveyVote surveyVote = new SurveyVote();
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = @"SELECT SurveyVoteId, SurveyId, SurveyOptionId
                         FROM SurveyVotes WHERE SurveyId = @SurveyId AND UserId = @UserId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SurveyId", surveyId);
                command.Parameters.AddWithValue("@UserId", userId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    surveyVote.SurveyOptionId = Convert.ToInt32(reader["SurveyOptionId"]);
                    surveyVote.SurveyId = Convert.ToInt32(reader["SurveyId"]);
                    surveyVote.Id = Convert.ToInt32(reader["SurveyVoteId"]);
                    surveyVote.UserId = userId;
                }
            }
            return surveyVote;
        }
    }
}
