using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<Users> getUsersContacts(Users user)
        {
            List<int> contactUserIDs = this.getContactUserIDs(user);
        
            List<Users> contacts = new List<Users>();

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
                        Users contact = new Users
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

        private List<int> getContactUserIDs(Users user)
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
    }
}
