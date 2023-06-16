using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    [TestClass]
    public class TestEventController
    {
        [TestMethod]
        public void TestGetEventsById()
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

        [TestMethod]
        public void TestSaveEvent()
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
    }
}
