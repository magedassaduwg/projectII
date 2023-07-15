using System.Data.SqlClient;
using TeaLeaves.Helper;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// DAL class for managing database Blocked relationships
    /// </summary>
    public class BlockedDAL
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

        /// <summary>
        /// method accepted an email and checks to see if the associated user is blocked. Returns true if blocked.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        public bool IsUserEmailBlocked(string userEmail)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                int userId = 0;
                SqlCommand command = new SqlCommand("SELECT UserId FROM Users WHERE Email = @Email;", connection);
                command.Parameters.AddWithValue("@Email", userEmail);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userId = reader.GetInt32(0);
                }
                return this.IsUserBlocked(CurrentUserStore.User.UserId, userId);
            }
        }
    }
}
