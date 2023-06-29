using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Tests the methods of the EventController class
    /// </summary>
    [TestClass]
    public class TestEventResponseController
    {

        /// <summary>
        /// Tests the AddEventResponse and DeleteEventResponse methods
        /// </summary>
        [TestMethod]
        public void TestAddEventResponseAndDeleteEventResponse()
        {
            EventResponseController controller = new EventResponseController();
            EventResponse userEventResponse = new EventResponse
            {
                InviterId = 24,
                ReceiverId = 25,
                EventId = 180,
                Accepted = false,
            };

            try
            {
                int eventResponseId = controller.AddEventResponse(userEventResponse);
                Assert.AreNotEqual(eventResponseId, 0);

                controller.DeleteEventResponse(25, 180);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetEventResponses method
        /// </summary>
        [TestMethod]
        public void TestGetEventResponses()
        {
            EventResponseController controller = new EventResponseController();
            List<EventResponse> userEventResponses;

            try
            {
                userEventResponses = controller.GetEventResponses(25);

                Assert.AreEqual(userEventResponses[0].Id, 85);
                Assert.AreEqual(userEventResponses[1].Id, 86);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the AcceptEventResponse method
        /// </summary>
        [TestMethod]
        public void TestAcceptEventResponse()
        {
            EventResponseController controller = new EventResponseController();
            List<EventResponse> userEventResponses;
            EventResponse userEventResponse = new EventResponse
            {
                InviterId = 24,
                ReceiverId = 25,
                EventId = 157,
                Accepted = false,
            };

            try
            {
                int eventResponseId = controller.AddEventResponse(userEventResponse);
                Assert.AreNotEqual(eventResponseId, 0);

                controller.AcceptEventResponse(25, 157);

                userEventResponses = controller.GetEventResponses(25);
                Assert.AreEqual(userEventResponses[3].Accepted, true);

                controller.DeleteEventResponse(25, 157);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}