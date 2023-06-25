using System.Data;
using System.Data.SqlClient;
using TeaLeaves.Models;

namespace TeaLeaves.DALs
{
    /// <summary>
    /// Model to apply CRUD operation for the MessageGroup
    /// </summary>
    public class GroupMemberDAL
    {
        /// <summary>
        /// Saves a new group to the database
        /// </summary>
        /// <param name="newGroup"></param>
        /// <returns></returns>
        public bool CreateMessageGroup(string groupName, string userIds)
        {
            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("CreateNewGroup", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@groupName", groupName);
                command.Parameters.AddWithValue("@userIds", userIds);

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
        }

        /// <summary>
        /// Gets a list of members in a group for the user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<GroupMember> GetMyGroupContact(int userId)
        {
            List<GroupMember> myGroups = new List<GroupMember>();
            List<int> myGroupIds = new List<int>();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlCommand command = new SqlCommand("select gm.GroupId from GroupMembers gm join Groups g on gm.GroupId = g.GroupId  where gm.UserId = @userId", connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    myGroupIds.Add(Convert.ToInt32(reader["GroupId"]));
                }
            }

            foreach (int groupId in myGroupIds)
            {
                myGroups.Add(GetGroupById(groupId));
            }

            return myGroups;
        }

        /// <summary>
        /// Gets a message group by groupId
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public GroupMember GetGroupById(int groupId)
        {
            GroupMember group = new GroupMember();

            using (SqlConnection connection = TeaLeavesConnectionstring.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select gm.GroupMemberId, gm.GroupId, g.GroupName, gm.UserId, " +
                    "(Select top 1 TimeStamp From Messages where GroupId = @groupId order by TimeStamp desc) " +
                    "TimeStamp from GroupMembers gm " +
                    "join Groups g on gm.GroupId = g.GroupId where gm.GroupId = @groupId", connection);

                adapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);

                connection.Open();
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt != null && dt.Rows.Count > 0)
                {
                    group.GroupName = dt.Rows[0]["GroupName"]?.ToString();
                    group.GroupId = Convert.ToInt32(dt.Rows[0]["GroupId"]);
                    group.GroupMemberId = Convert.ToInt32(dt.Rows[0]["GroupMemberId"]);

                    if (dt.Rows[0]["TimeStamp"] != DBNull.Value)
                    {
                        group.TimeStamp = Convert.ToDateTime(dt.Rows[0]["TimeStamp"]);
                    }

                    group.UserIds = dt.AsEnumerable().Select(x => x.Field<int>("UserId")).ToArray();
                }
            }

            return group;
        }
    }
}
