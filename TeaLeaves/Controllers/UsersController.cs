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
        /// Adds a user to the database
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user)
        {
            _userDAL.AddUser(user);
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
    }
}
