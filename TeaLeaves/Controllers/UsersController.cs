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
        public Users VerifyUserCredentials(Users user)
        {
            return _userDAL.VerifyUserCredentials(user);
        }

        /// <summary>
        /// Adds a user to the database
        /// </summary>
        /// <param name="user"></param>
        public void Add(Users user)
        {
            _userDAL.AddUser(user);
        }
    }
}
