using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// Test Class for the message controller
    /// </summary>
    [TestClass]
    public class TestMessageController
    {
        /// <summary>
        /// Tests fetching message by a user
        /// </summary>
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

        /// <summary>
        /// Tests sending message to a nother user
        /// </summary>
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
                TimeStamp = DateTime.Now.ToUniversalTime(),
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
