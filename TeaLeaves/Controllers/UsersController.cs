using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    public class UsersController
    {
        private UsersDAL _userDAL;

        /// <summary>
        /// Constructor to instantiate a new controller
        /// </summary>
        public UsersController()
        {
            _userDAL = new UsersDAL();
        }

        /// <summary>
        /// Verifies that the user is valid
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User VerifyUserCredentials(User user)
        {
            return _userDAL.VerifyUserCredentials(user);
        }

        /// <summary>
        /// Gets a user by id provided
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public User GetUserById(int userId)
        {
            return _userDAL.GetUserById(userId);
        }

        /// <summary>
        /// Adds a user to the database
        /// </summary>
        /// <param name="user"></param>
        public int Add(User user)
        {
            return _userDAL.AddUser(user);
        }

        /// <summary>
        /// Removes the given user from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Delete(int userId)
        {
            return _userDAL.DeleteUser(userId);
        }

        /// <summary>
        /// method retrieving the profile picture of a given user from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Image GetUserProfilePicture(int userId)
        {
            return this._userDAL.GetUserProfilePicture(userId);
        }

        /// <summary>
        /// method retrieving the givne user's blurb from the database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetUserBlurb(int userId)
        {
            return this._userDAL.GetUserBlurb(userId);
        }

        /// <summary>
        /// method setting the blurb of a user in the database.
        /// </summary>
        /// <param name="user"></param>
        public Boolean SetUserBlurb(Models.User user)
        {
            return this._userDAL.SetUserBlurb(user);
        }

        /// <summary>
        /// method uploading a User's ProfilePicture
        /// </summary>
        /// <param name="user"></param>
        public Boolean UploadProfilePicture(Models.User user)
        {
           return this._userDAL.UploadProfilePicture(user);
        }
    }
}
