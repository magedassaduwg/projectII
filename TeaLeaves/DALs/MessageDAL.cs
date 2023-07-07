using System.Data;
using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// Data access layer for the messages table
    /// </summary>
    public class MessageDAL
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
                SqlCommand command = new SqlCommand("select top 50 MessageId, SenderId, ReceiverId, Text, MediaId, GroupId, TimeStamp " +
                    "from dbo.Messages where (SenderId = @senderId and ReceiverId = @receiverId) or (SenderId = @receiverId and ReceiverId = @senderId) and GroupId is null " +
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
                    if (reader["GroupId"] != DBNull.Value)
                    {
                        message.GroupId = Convert.ToInt32(reader["GroupId"]);
                    }

                    messages.Add(message);
                }
            }

            messages.Reverse();

            return messages;
        }
        /// <summary>
        /// Gets message history for a group
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="contactId"></param>
        public List<IUserMessage> GetMessagesByGroupId(int groupId)
        {
            List<IUserMessage> messages = new List<IUserMessage>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("select top 50 MessageId, SenderId, ReceiverId, Text, MediaId, GroupId, TimeStamp " +
                    "from dbo.Messages where GroupId = @groupId order by TimeStamp Desc", connection);

                command.Parameters.AddWithValue("@groupId", groupId);

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
                    if (reader["GroupId"] != DBNull.Value)
                    {
                        message.GroupId = Convert.ToInt32(reader["GroupId"]);
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
                SqlCommand command = new SqlCommand("Insert into Messages(SenderId, ReceiverId, Text, MediaId, GroupId, Timestamp) " +
                                                "Values(@senderId, @receiverId, @text, @mediaId,@groupId, @timestamp) " +
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

                if (message.GroupId != null)
                {
                    command.Parameters.AddWithValue("@groupId", message.GroupId);
                }
                else
                {
                    command.Parameters.AddWithValue("@groupId", DBNull.Value);
                }

                command.Parameters.AddWithValue("@timestamp", message.TimeStamp);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        /// <summary>
        /// Deletes a message by a given messageId
        /// </summary>
        /// <param name="messageId"></param>
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

        /// <summary>
        /// Saves an image to the database and returns the mediaId
        /// </summary>
        /// <param name="base64Image"></param>
        /// <returns></returns>
        public int SaveBase64Image(string base64Image)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("Insert Into Medias(Image) Values(@image); select scope_identity()", connection);

                command.Parameters.AddWithValue("@image", base64Image);
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        /// <summary>
        /// Returns the base64 image as a sting
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public string GetBase64Media(int mediaId)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("Select Image From Medias where MediaId = @mediaId", connection);

                command.Parameters.AddWithValue("@mediaId", mediaId);
                connection.Open();
                return command.ExecuteScalar()?.ToString();
            }
        }

        /// <summary>
        /// Forwards a message in the database to another contact
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="destinationId"></param>
        /// <param name="isGroupId"></param>
        public void ForwardMessage(int messageId, int senderId, int destinationId, bool isGroupId)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("ForwardMessage", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@messageId", messageId);
                command.Parameters.AddWithValue("@destinationId", destinationId);
                command.Parameters.AddWithValue("@senderId", senderId);
                command.Parameters.AddWithValue("@isGroupId", isGroupId);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
