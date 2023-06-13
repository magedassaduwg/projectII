using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// DAL for the modification and retrieval of Contacts from the Database
    /// </summary>
    internal class ContactsDAL
    {
        /// <summary>
        /// method to retrieve a list of a user's contacts represented by a list of Users objects
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> GetUsersContacts(User user)
        {
            List<int> contactUserIDs = this.GetContactUserIDs(user);
        
            List<User> contacts = new List<User>();

            foreach (int userId in contactUserIDs)
            {
                using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
                {
                    string query = "SELECT UserId, FirstName, LastName, Username, Email FROM Users WHERE UserId = @UserId;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        User contact = new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }

        /// <summary>
        /// method to retrieve a list of a user's contacts represented by a list of Users objects for a given event
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> GetUsersContactsByEvent(User user, Event @event)
        {
            List<int> contactUserIDs = this.GetContactUserIDs(user);

            List<User> contacts = new List<User>();

            foreach (int userId in contactUserIDs)
            {
                using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
                {
                    string query = "SELECT UserId, FirstName, LastName, Username, Email FROM Users u " +
                        "JOIN EventResponses er ON u.UserId = er.ReceiverId WHERE UserId = @UserId AND er.EventId = @EventId;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@EventId", @event.Id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        User contact = new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }

        /// <summary>
        /// method to retrieve a list of a user's contacts represented by a list of Users objects for a given event who have not been invited
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> GetUsersContactsNotInvitedByEvent(User user, Event @event)
        {
            List<int> contactUserIDs = this.GetContactUserIDs(user);

            List<User> contacts = new List<User>();

            foreach (int userId in contactUserIDs)
            {
                using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
                {
                    string query = "SELECT UserId, FirstName, LastName, Username, Email FROM Users u " +
                        "JOIN EventResponses er ON u.UserId != er.ReceiverId WHERE UserId = @UserId AND er.EventId = @EventId;";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@EventId", @event.Id);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        User contact = new User
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }

        private List<int> GetContactUserIDs(User user)
        {
            List<int> contactUserIDs = new List<int>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT UserId2 FROM Contacts WHERE UserId1 = @userId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userID", user.UserId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contactUserIDs.Add(reader.GetInt32(0));
                }
                return contactUserIDs;
            }
        }

        /// <summary>
        /// method deleting a contact from a User's contact list in the database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="contact"></param>
        public void RemoveContact(User user, User contact)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM Contacts WHERE UserId1 = @UserId1 AND UserId2 = @UserId2", connection);
                command.Parameters.AddWithValue("@UserId1", user.UserId);
                command.Parameters.AddWithValue("@UserId2", contact.UserId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
