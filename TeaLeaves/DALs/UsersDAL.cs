using System.Data.SqlClient;

namespace TeaLeaves.DALs
{
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
        public void AddUser(Models.User user)
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
                    } catch (Exception ex)
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
                    } catch (Exception ex)
                    {
                        userBlurb = "";
                    }
                }
            }
            return userBlurb;
        }
    }
}

