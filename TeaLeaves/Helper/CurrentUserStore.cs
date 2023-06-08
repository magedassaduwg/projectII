using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeaves.Helper
{
    /// <summary>
    /// In-memory storage of the current user
    /// </summary>
    public static class CurrentUserStore
    {
        public static Dictionary<string, List<Models.UserMessage>> MessageHistory = new Dictionary<string, List<Models.UserMessage>>();
        public delegate void EventHandler(IUserMessage message);
        public static event EventHandler IncomingMessageEvent;
        public static User User;

        /// <summary>
        /// Sets the logged in user
        /// </summary>
        /// <param name="user"></param>
        public static void SetCurrentUser(User user)
        {
            User = user;
            RabbitBusController.AddConsumer(user.Username);
        }

        /// <summary>
        /// Clear the logged in user
        /// </summary>
        public static void Logout()
        {
            User = null;
            MessageHistory = null;
            RabbitBusController.StopRabbitConnection();
        }

        /// <summary>
        /// Fire event to receive message from sender
        /// </summary>
        /// <param name="message"></param>
        public static void NewMessageReceived(IUserMessage message)
        {
            if (IncomingMessageEvent != null)
            {
                IncomingMessageEvent(message);
            }
        }
    }
}
