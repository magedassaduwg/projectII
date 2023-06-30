using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Test class for testing group messaging controller
    /// </summary>
    [TestClass]
    public class TestGroupMemberController
    {
        /// <summary>
        /// Tests creating a new group and group members
        /// </summary>
        [TestMethod]
        public void TestCreateController()
        {
            GroupMemberController controller = new GroupMemberController();

            try
            {
                int groupId = controller.CreateNewGroup("Test Group", "1,2,3,4");

                Assert.IsTrue(groupId > 0);

                Assert.IsTrue(controller.DeleteGroupById(groupId));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Tests the ability to fetch a group and it's members correctly
        /// </summary>
        [TestMethod]
        public void TestGetGroupById()
        {
            GroupMemberController controller = new GroupMemberController();

            try
            {
                GroupMember members = controller.GetGroupById(1);

                Assert.IsTrue(members != null && members.GroupId > 0 && members.UserIds?.Length > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        /// <summary>
        /// Tests the ability to fetch all groups a member is in by their userId
        /// </summary>
        [TestMethod]
        public void TestGetGroupContacts()
        {
            GroupMemberController controller = new GroupMemberController();

            try
            {
                List<GroupMember> groups = controller.GetMyGroupContact(1);

                Assert.IsTrue(groups != null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
