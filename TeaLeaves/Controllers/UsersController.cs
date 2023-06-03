
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

        public Users VerifyUserCredentials(Users user)
        {
            return _userDAL.VerifyUserCredentials(user);
        }
    }
}
