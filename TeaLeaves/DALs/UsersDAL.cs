using TeaLeaves.Models;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace TeaLeaves.DALs
{
    public class UsersDAL
    {
        /// <summary>
        /// Checks the database to see if the given users information is valid
        /// </summary>
        /// <returns></returns>
        public Users VerifyUserCredentials(Users user)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.Email = reader["Email"].ToString();
                    return user;
                }
                return null;
            }
        }

        /// <summary>
        /// Adds a new user to the database
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(Users user)
        {
            string insertStatement =
                "INSERT INTO Users (LastName, FirstName, Username, Password, Email) " +
                "VALUES (@lastName, @firstName, @username, @password, @email) ";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@lastName", user.LastName);
                insertCommand.Parameters.AddWithValue("@firstName", user.FirstName);
                insertCommand.Parameters.AddWithValue("@username", user.Username);
                insertCommand.Parameters.AddWithValue("@password", user.Password);
                insertCommand.Parameters.AddWithValue("@email", user.Email);
                insertCommand.ExecuteReader();
            }
        }
    }
}

