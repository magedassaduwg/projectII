using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaLeaves.DALs;

namespace TeaLeaves.Controllers
{
    internal class BlockedController
    {
        private BlockedDAL _blockedDAL;

        public BlockedController()
        {
            this._blockedDAL = new BlockedDAL();
        }

        public bool BlockUser(int currentUserId, int blockedUserId)
        {
            return this._blockedDAL.BlockUser(currentUserId, blockedUserId);
        }
    }
}
