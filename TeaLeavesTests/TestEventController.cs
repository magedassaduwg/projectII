using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Tests the methods of the EventController class
    /// </summary>
    [TestClass]
    public class TestEventController
    {
        /// <summary>
        /// Tests the GetEventsByUserId method.
        /// </summary>
        [TestMethod]
        public void TestGetEventsByUserId()
        {
            EventController controller = new EventController();
            try
            {
                var messages = controller.GetEventsByUserId(1);
                Assert.IsTrue(messages.Any());
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the SaveEvent and DeleteEvent methods
        /// </summary>
        [TestMethod]
        public void TestSaveEventAndDeleteEvent()
        {
            EventController controller = new EventController();
            Event userEvent = new Event
            {
                Id = 0,
                EventName = "test",
                EventDateTime = DateTime.Now,
                Description = "test",
                CreatorId = 24,
                State = "test",
                City = "test",
                Zipcode = 12345,
                StreetNumber = "test",
                Category = "test",
            };

            try
            {
                int eventId = controller.SaveEvent(userEvent);
                Assert.AreNotEqual(eventId, 0);

                controller.DeleteEvent(eventId);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetEventById method
        /// </summary>
        [TestMethod]
        public void TestGetEventById()
        {
            EventController controller = new EventController();
            Event userEvent;
            try
            {
                userEvent = controller.GetEventById(153);
                Assert.AreEqual(userEvent.EventName, "test");
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetEventsReceivedByUserId method
        /// </summary>
        [TestMethod]
        public void TestGetEventsReceivedByUserId()
        {
            EventController controller = new EventController();
            List<Event> userEvents;
            try
            {
                userEvents = controller.GetEventsReceivedByUserId(25);
                Assert.AreEqual(userEvents[0].Id, 153);
                Assert.AreEqual(userEvents[1].Id, 156);
                Assert.AreEqual(userEvents[2].Id, 163);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetAcceptedEventsReceivedByUserId method
        /// </summary>
        [TestMethod]
        public void TestGetAcceptedEventsReceivedByUserId()
        {
            EventController controller = new EventController();
            List<Event> userEvents;
            try
            {
                userEvents = controller.GetAcceptedEventsReceivedByUserId(25);
                Assert.AreEqual(userEvents[0].Id, 155);
                Assert.AreEqual(userEvents[1].Id, 161);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
