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
            List<User> contacts = new List<User>();

            //foreach (int userId in contactUserIDs)
            //{
                using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
                {
                //string query = "SELECT UserId, FirstName, LastName, Username, Email FROM Users u " +
                //    "JOIN EventResponses er ON u.UserId = er.EventReceiverId WHERE UserId = @UserId AND er.EventId = @EventId;";
                string query = "SELECT DISTINCT UserId, FirstName, LastName, Username, Email " +
                    "FROM Contacts c JOIN EventResponses er ON er.EventId = @EventId AND er.EventInviterId = @UserId " +
                    "JOIN Users u ON c.UserId1 = @UserId  AND UserId = er.EventReceiverId " +
                    "WHERE UserId = c.UserId2 AND UserId = er.EventReceiverId";

                SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserId", user.UserId);
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
                //}
            }
            return contacts;
        }

        public List<User> GetUsersContactsNotInvitedByEvent(User user, Event @event)
        {
            List<int> contactUserIDs = this.GetContactUserIDs(user);
            List<int> contactUserIDsInvited = this.GetContactUserIDsByEvent(user, @event);

            contactUserIDs = contactUserIDs.Except(contactUserIDsInvited).ToList();

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

        private List<int> GetContactUserIDsByEvent(User user, Event @event)
        {
            List<int> contactUserIDs = new List<int>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT DISTINCT UserId, FirstName, LastName, Username, Email FROM Contacts c JOIN EventResponses er ON er.EventId = 2 AND er.EventInviterId = 3 JOIN Users u ON c.UserId1 = 3 WHERE UserId = c.UserId2 AND c.UserId2 = er.EventReceiverId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@EventId", @event.Id);

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
        public Boolean RemoveContact(Models.User user, Models.User contact)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("DELETE FROM Contacts WHERE UserId1 = @UserId1 AND UserId2 = @UserId2", connection);
                command.Parameters.AddWithValue("@UserId1", user.UserId);
                command.Parameters.AddWithValue("@UserId2", contact.UserId);

                connection.Open();
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// method that calls on helper method to check if a email exists. If so, returns true and adds the contact.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public Boolean AddContact(User user, string email)
        {
            if (!DoesEmailExist(email))
            {
                return false;
            }
            int contactId = this.GetUserId(email);

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("INSERT INTO Contacts(UserId1, UserId2) VALUES(@UserId1, @UserId2);", connection);
                command.Parameters.AddWithValue("@UserId1", user.UserId);
                command.Parameters.AddWithValue("@UserId2", contactId);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
        }

        private int GetUserId(string email)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT UserId FROM Users WHERE Email = @email;", connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                int userId = Convert.ToInt32(command.ExecuteScalar());
                return userId;
            }
        }

        private Boolean DoesEmailExist(string email)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT UserId FROM Users WHERE Email = @email;", connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                
                if (command.ExecuteScalar() == null)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
        }
    }
}
