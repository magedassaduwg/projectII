using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    [TestClass]
    public class TestMessageController
    {
        [TestMethod]
        public void TestGetMessages()
        {
            MessageController controller = new MessageController();
            try
            {
                var messages = controller.GetMessagesByUserId(1, 2);
                Assert.IsTrue(messages.Any());
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestSaveMessage()
        {
            MessageController controller = new MessageController();
            UserMessage message = new UserMessage
            {
                MediaId = null,
                MessageId = 0,
                ReceiverId = 2,
                SenderId = 1,
                Text = "Test",
                TimeStamp = DateTime.Now
            };

            try
            {
                int messageId = controller.SaveMessageToDatabase(message);
                Assert.AreNotEqual(messageId, 0);

                controller.DeleteMessageFromDatabase(messageId);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
