using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{

    /// <summary>
    /// The DAL for the SurveyInvites table
    /// </summary>
    public class SurveyInviteDAL
    {
        /// <summary>
        /// method to retrieve a list of SurveyInvites with the given receiverId
        /// </summary>
        /// <param name="receiverId"></param>
        /// <returns></returns>
        public List<SurveyInvite> GetSurveyInvitesByReceivingId(int receiverId)
        {
            List<SurveyInvite> userSurveyInvites = new List<SurveyInvite>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT SurveyInviteId, SurveyInviterId, SurveyReceiverId, SurveyId, Answered FROM SurveyInvites WHERE SurveyReceiverId = @ReceiverId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReceiverId", receiverId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SurveyInvite userSurveyInvite = new SurveyInvite
                    {
                        Id = Convert.ToInt32(reader["SurveyInviteId"]),
                        InviterId = Convert.ToInt32(reader["SurveyInviterId"]),
                        ReceiverId = Convert.ToInt32(reader["SurveyReceiverId"]),
                        SurveyId = Convert.ToInt32(reader["SurveyId"]),
                        Answered = Convert.ToInt32(reader["Answered"]) > 0,
                    };
                    userSurveyInvites.Add(userSurveyInvite);
                }
            }
            return userSurveyInvites;
        }

        /// <summary>
        /// Deletes a SurveyInvites from the database
        /// </summary>
        /// <param name="receiverId"></param>
        /// <param name="surveyId"></param>
        /// <returns></returns>
        public bool DeleteSurveyInvite(int receiverId, int surveyId)
        {
            string query = @"DELETE FROM SurveyInvites
                             WHERE SurveyReceiverId = @SurveyReceiverId AND SurveyId = @SurveyId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@SurveyReceiverId", receiverId);
                    saveCommand.Parameters.AddWithValue("@SurveyId", surveyId);
                    return saveCommand.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Inserts a new SurveyInvite row into the database
        /// </summary>
        /// <param name="surveyInvite"></param>
        /// <returns></returns>
        public int AddSurveyInvite(SurveyInvite surveyInvite)
        {

            string query = @"INSERT INTO SurveyInvites (SurveyInviterId, SurveyReceiverId, SurveyId, Answered) 
                             VALUES (@InvitedId, @ReceivedId, @SurveyId, @Answered)
                             select scope_identity()";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@InvitedId", surveyInvite.InviterId);
                    saveCommand.Parameters.AddWithValue("@ReceivedId", surveyInvite.ReceiverId);
                    saveCommand.Parameters.AddWithValue("@SurveyId", surveyInvite.SurveyId);
                    saveCommand.Parameters.AddWithValue("@Answered", surveyInvite.Answered);
                    return Convert.ToInt32(saveCommand.ExecuteScalar());
                }
            }
        }
    }
}
