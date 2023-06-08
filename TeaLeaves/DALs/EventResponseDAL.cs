using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// The DAL for interacting with the EventResponse table
    /// </summary>
    public class EventResponseDAL
    {

        /// <summary>
        /// method to retrieve a list of EventResponses with the given receiverId
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<EventResponse> GetEventsByReceivingId(int receiverId)
        {
            List<EventResponse> userEventResponses = new List<EventResponse>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT EventResponseId, EventInviterId, EventReceiverId, EventId FROM Events WHERE ReceiverId = @ReceiverId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReceiverId", receiverId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EventResponse userEventResponse = new EventResponse
                    {
                        Id = Convert.ToInt32(reader["EventResponseId"]),
                        InviterId = Convert.ToInt32(reader["EventInviterId"]),
                        ReceiverId = Convert.ToInt32(reader["EventReceiverId"]),
                        EventId = Convert.ToInt32(reader["EventId"]),
                    };
                    userEventResponses.Add(userEventResponse);
                }
            }
            return userEventResponses;
        }
    }
}
