using System.Data.SqlClient;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// Data access layer for the Users table
    /// </summary>
    public class UsersDAL
    {
        /// <summary>
        /// Checks the database to see if the given users information is valid
        /// </summary>
        /// <returns></returns>
        public Models.User VerifyUserCredentials(Models.User user)
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
                    user.UserId = Convert.ToInt32(reader["UserId"]);
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
        public int AddUser(Models.User user)
        {
            string insertStatement =
                "INSERT INTO Users (LastName, FirstName, Username, Password, Email) " +
                "VALUES (@lastName, @firstName, @username, @password, @email) " +
                "select scope_identity()";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@lastName", user.LastName);
                insertCommand.Parameters.AddWithValue("@firstName", user.FirstName);
                insertCommand.Parameters.AddWithValue("@username", user.Username);
                insertCommand.Parameters.AddWithValue("@password", user.Password);
                insertCommand.Parameters.AddWithValue("@email", user.Email);
                return Convert.ToInt32(insertCommand.ExecuteScalar());
            }
        }

        /// <summary>
        /// Returns a user with the given userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Models.User GetUserById(int userId)
        {
            Models.User user = new Models.User();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                string query = "Select FirstName, LastName, Username, Email, Blurb From Users Where UserId = @userId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.UserId = userId;
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.Username = reader["Username"].ToString();
                    user.Blurb = reader["Blurb"].ToString();

                    return user;
                }

                return null;
            }
        }

        /// <summary>
        /// Removes the given user from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool DeleteUser(int userId)
        {
            string query = @"DELETE Users " +
                            "WHERE UserId = @userId";
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                connection.Open();

                using (SqlCommand saveCommand = new SqlCommand(query, connection))
                {
                    saveCommand.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = saveCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        /// <summary>
        /// method retrieving the profile picture of a given user from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Image GetUserProfilePicture(int userId)
        {
            MemoryStream userImage = new MemoryStream();
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("Select ProfilePicture FROM Users WHERE UserId = @UserId;", connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        var bytes = (byte[])reader["ProfilePicture"];
                        userImage.Write(bytes);
                        Image loadedImage = Image.FromStream(userImage);
                        return loadedImage;
                    }
                    catch (Exception ex)
                    {

                    }
                }
                Image defaultImage = Image.FromFile("Resources\\user.png");
                return defaultImage;
            }
        }

        /// <summary>
        /// method retrieving the givne user's blurb from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetUserBlurb(int userId)
        {
            string userBlurb = "";

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("Select Blurb FROM Users WHERE UserId = @UserId;", connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        userBlurb = reader["Blurb"].ToString();
                    }
                    catch (Exception ex)
                    {
                        userBlurb = "";
                    }
                }
            }
            return userBlurb;
        }

        /// <summary>
        /// method setting the blurb of a user in the database.
        /// </summary>
        /// <param name="user"></param>
        public Boolean SetUserBlurb(Models.User user)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE Users SET Blurb = @blurb WHERE UserId = @UserId", connection);
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@blurb", user.Blurb);

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
        /// method uploading a User's ProfilePicture
        /// </summary>
        /// <param name="user"></param>
        public Boolean UploadProfilePicture(Models.User user)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("UPDATE Users SET ProfilePicture = @profilePicture WHERE UserId = @UserId", connection);
                command.Parameters.AddWithValue("@UserId", user.UserId);
                command.Parameters.AddWithValue("@profilePicture", this.ImageToByte(user.ProfilePicture));
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

        private byte[] ImageToByte(Image img)
        {
            byte[] byteArray = new byte[0];
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Close();

                byteArray = stream.ToArray();
            }
            return byteArray;
        }

        /// <summary>
        /// method retrieving the percent of accepted invites for the giver UserID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public double[] GetUserStats(int userId)
        {
            double[] userStats = new double[2];
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("GetPercentAccepted", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        userStats[0] = Math.Round((Convert.ToDouble(reader["AcceptedPercentage"])), 1);
                        userStats[1] = (Convert.ToInt32(reader["Total"]));
                    }
                    catch
                    {
                        
                    }
                }
            }
            return userStats;
        }
        
    }
}

