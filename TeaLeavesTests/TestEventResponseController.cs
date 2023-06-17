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
                EventId = 81,
                Accepted = false,
            };

            try
            {
                int eventResponseId = controller.AddEventResponse(userEventResponse);
                Assert.AreNotEqual(eventResponseId, 0);

                controller.DeleteEventResponse(25, 81);
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

                Assert.AreEqual(userEventResponses[0].Id, 19);
                Assert.AreEqual(userEventResponses[1].Id, 21);
                Assert.AreEqual(userEventResponses[2].Id, 22);
                Assert.AreEqual(userEventResponses[3].Id, 23);
                Assert.AreEqual(userEventResponses[4].Id, 24);
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
                EventId = 81,
                Accepted = false,
            };

            try
            {
                int eventResponseId = controller.AddEventResponse(userEventResponse);
                Assert.AreNotEqual(eventResponseId, 0);

                controller.AcceptEventResponse(25, 81);

                userEventResponses = controller.GetEventResponses(25);
                Assert.AreEqual(userEventResponses[5].Accepted, true);

                controller.DeleteEventResponse(25, 81);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}