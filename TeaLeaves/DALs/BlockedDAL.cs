using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// DAL class for managing database Blocked relationships
    /// </summary>
    internal class BlockedDAL
    {

        /// <summary>
        /// method creating a Blocked relationship between two Users
        /// </summary>
        /// <param name="currentUserId"></param>
        /// <param name="blockedUserId"></param>
        /// <returns></returns>
        public bool BlockUser(int currentUserId, int blockedUserId)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                
                SqlCommand command = new SqlCommand("INSERT INTO Blocked(UserId1, UserId2) VALUES(@UserId1, @UserId2); " +
                                    "INSERT INTO Blocked(UserId1, UserId2) VALUES(@UserId2, @UserId1)", connection);
                command.Parameters.AddWithValue("@UserId1", currentUserId);
                command.Parameters.AddWithValue("@UserId2", blockedUserId);

                connection.Open();
                command.ExecuteNonQuery();
                return true;
                
            }
        }

        /// <summary>
        /// method checking if a blocked relationship exists between two given users. If yes, returns true. Otherwise false.
        /// </summary>
        /// <param name="currentUserId"></param>
        /// <param name="blockedUserId"></param>
        /// <returns></returns>
        public bool IsUserBlocked(int currentUserId, int blockedUserId)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Blocked WHERE UserId1 = @UserId1 AND UserId2 = @UserId2", connection);
                command.Parameters.AddWithValue("@UserId1", currentUserId);
                command.Parameters.AddWithValue("@UserId2", blockedUserId);
                connection.Open();

                if (command.ExecuteScalar() == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
