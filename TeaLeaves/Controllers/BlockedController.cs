using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaLeaves.DALs;

namespace TeaLeaves.Controllers
{
    public class BlockedController
    {
        private BlockedDAL _blockedDAL;

        public BlockedController()
        {
            this._blockedDAL = new BlockedDAL();
        }

        /// <summary>
        /// method creating a Blocked relationship between two Users
        /// </summary>
        /// <param name="currentUserId"></param>
        /// <param name="blockedUserId"></param>
        /// <returns></returns>
        public bool BlockUser(int currentUserId, int blockedUserId)
        {
            return this._blockedDAL.BlockUser(currentUserId, blockedUserId);
        }

        /// <summary>
        /// method checking if a blocked relationship exists between two given users. If yes, returns true. Otherwise false.
        /// </summary>
        /// <param name="currentUserId"></param>
        /// <param name="blockedUserId"></param>
        /// <returns></returns>
        public bool IsUserBlocked(int currentUserId, int blockedUserId)
        {
            return this._blockedDAL.IsUserBlocked(currentUserId, blockedUserId);
        }

        /// <summary>
        /// method checking if a user with the given email is blocked.
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        public bool IsUserEmailBlocked(string userEmail)
        {
            return this._blockedDAL.IsUserEmailBlocked(userEmail);
        }
    }
}
