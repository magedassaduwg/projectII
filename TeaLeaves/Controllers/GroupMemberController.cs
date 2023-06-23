using TeaLeaves.DALs;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// Controller class to communicate with the DAL
    /// </summary>
    public class GroupMemberController
    {

        private GroupMemberDAL _groupMemberDAL;

        /// <summary>
        /// Constructor to initialize the DAL access
        /// </summary>
        public GroupMemberController()
        {
            _groupMemberDAL = new GroupMemberDAL();
        }

        /// <summary>
        /// Creates a new group in the database
        /// </summary>
        /// <param name="groupName"></param>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public bool CreateNewGroup(string groupName, string userIds)
        {
            return _groupMemberDAL.CreateMessageGroup(groupName, userIds);
        }

        /// <summary>
        /// Returns a list of groups the user in
        /// </summary>
        /// <returns></returns>
        public List<GroupMember> GetMyGroupContact(int userId)
        {
            return _groupMemberDAL.GetMyGroupContact(userId);
        }

        /// <summary>
        /// Returns a list of groups the user in
        /// </summary>
        /// <returns></returns>
        public GroupMember GetGroupById(int groupId)
        {
            return _groupMemberDAL.GetGroupById(groupId);
        }
    }
}
