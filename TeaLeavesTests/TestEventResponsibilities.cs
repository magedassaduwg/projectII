using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Tests the methods of the EventResponsibilityController class
    /// </summary>
    [TestClass]
    public class TestEventResponsibilities
    {
        /// <summary>
        /// Tests the AddResponsibility and DeleteEventResponsibility methods
        /// </summary>
        [TestMethod]
        public void TestSaveAddResponsibilityAndDeleteEventResponsibility()
        {
            EventResponsibilityController controller = new EventResponsibilityController();
            EventResponsibility userEventResponsibility = new EventResponsibility
            {
                Name = "test",
                EventId = 153,
            };

            try
            {
                int eventResponsibilityId = controller.AddEventResponsibility(userEventResponsibility);
                Assert.AreNotEqual(eventResponsibilityId, 0);

                controller.DeleteEventResponsibility(eventResponsibilityId);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        // <summary>
        /// Tests the AassignEventResponsibility method
        /// </summary>
        [TestMethod]
        public void TestAssignEventResponsibility()
        {
            EventResponsibilityController controller = new EventResponsibilityController();
            EventResponsibility userEventResponsibility = new EventResponsibility
            {
                Name = "test",
                EventId = 153,
            };

            User user = new User
            {
                UserId = 84,
            };
            List<EventResponsibility> eventResponsibilities = new List<EventResponsibility>();

            try
            {
                int eventResponsibilityId = controller.AddEventResponsibility(userEventResponsibility);
                Assert.AreNotEqual(eventResponsibilityId, 0);

                int eventResponsibilityId2 = controller.AssignEventResponsibility(user, 153, "test");
                Assert.AreNotEqual(eventResponsibilityId2, 0);

                eventResponsibilities = controller.GetEventResponsibilitiesByEventId(153);

                eventResponsibilities[4].UserId = 84;

                controller.DeleteEventResponsibility(eventResponsibilityId);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        // <summary>
        /// Tests the GetEventResponsibilitiesByUserIdAndEventId method
        /// </summary>
        [TestMethod]
        public void TestGetEventResponsibilitiesByUserIdAndEventId()
        {
            EventResponsibilityController controller = new EventResponsibilityController();
            List<EventResponsibility> eventResponsibilities;

            try
            {
                eventResponsibilities = controller.GetEventResponsibilitiesByUserIdAndEventId(25, 153);
                Assert.AreEqual(eventResponsibilities[0].Id, 31);
                Assert.AreEqual(eventResponsibilities[1].Id, 34);

            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        // <summary>
        /// Tests the GetUnassignedEventResponsibilitiesByEventId method
        /// </summary>
        [TestMethod]
        public void GetUnassignedEventResponsibilitiesByEventId()
        {
            EventResponsibilityController controller = new EventResponsibilityController();
            List<EventResponsibility> eventResponsibilities;

            try
            {
                eventResponsibilities = controller.GetUnassignedEventResponsibilitiesByEventId(153);
                Assert.AreEqual(eventResponsibilities[0].Id, 32);
                Assert.AreEqual(eventResponsibilities[1].Id, 33);

            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
