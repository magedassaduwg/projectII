using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// Data access layer for the messages table
    /// </summary>
    public class MessagessDAL
    {
        /// <summary>
        /// Gets message history between two users with paging
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="contactId"></param>
        public List<IUserMessage> GetMessagesByUserId(int userId, int contactId)
        {
            List<IUserMessage> messages = new List<IUserMessage>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("select top 50 MessageId, SenderId, ReceiverId, Text, MediaId, TimeStamp " +
                    "from dbo.Messages where SenderId in (@receiverId, @senderId) or ReceiverId in (@receiverId, @senderId) " +
                    "order by TimeStamp Desc", connection);

                command.Parameters.AddWithValue("@receiverId", userId);
                command.Parameters.AddWithValue("@senderId", contactId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    IUserMessage message = new UserMessage
                    {

                        Text = reader["Text"].ToString(),
                        MessageId = Convert.ToInt32(reader["MessageId"]),
                        ReceiverId = Convert.ToInt32(reader["ReceiverId"]),
                        SenderId = Convert.ToInt32(reader["SenderId"]),
                        TimeStamp = Convert.ToDateTime(reader["TimeStamp"])
                    };

                    if (reader["MediaId"] != DBNull.Value)
                    {
                        message.MediaId = Convert.ToInt32(reader["MediaId"]);
                    }

                    messages.Add(message);
                }
            }

            messages.Reverse();

            return messages;
        }

        /// <summary>
        /// Saves a message between contacts in the database
        /// </summary>
        /// <param name="message"></param>
        public int SaveMessage(IUserMessage message)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("Insert into Messages(SenderId, ReceiverId, Text, MediaId, Timestamp) " +
                                                "Values(@senderId, @receiverId, @text, @mediaId, @timestamp) " +
                                                "select scope_identity()", connection);

                command.Parameters.AddWithValue("@senderId", message.SenderId);
                command.Parameters.AddWithValue("@receiverId", message.ReceiverId);
                command.Parameters.AddWithValue("@text", message.Text);

                if (message.MediaId != null)
                {
                    command.Parameters.AddWithValue("@mediaId", message.MediaId);
                }
                else
                {
                    command.Parameters.AddWithValue("@mediaId", DBNull.Value);
                }
                command.Parameters.AddWithValue("@timestamp", message.TimeStamp);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void DeleteMessageById(int messageId)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("Delete From Messages where MessageId = @messageId", connection);
                
                command.Parameters.AddWithValue("@messageId", messageId);
                connection.Open();
                command.ExecuteScalar();
            }
        }
    }
}
