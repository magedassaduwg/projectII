using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// In-memory storage of the current user
    /// </summary>
    public static class CurrentUser
    {
        public static Dictionary<string, List<Models.Message>> MessageHistory = new Dictionary<string, List<Models.Message>>();
        public delegate void EventHandler(IMessage message);
        public static event EventHandler IncomingMessageEvent;
        public static User User;

        /// <summary>
        /// Sets the logged in user
        /// </summary>
        /// <param name="user"></param>
        public static void SetCurrentUser(User user)
        {
            User = user;
            RabbitBus.AddConsumer(user.Username);
        }

        /// <summary>
        /// Clear the logged in user
        /// </summary>
        public static void Logout()
        {
            User = null;
            MessageHistory = null;
            RabbitBus.StopRabbitConnection();
        }

        /// <summary>
        /// Fire event to receive message from sender
        /// </summary>
        /// <param name="message"></param>
        public static void NewMessageReceived(IMessage message)
        {
            if (IncomingMessageEvent != null)
            {
                IncomingMessageEvent(message);
            }
        }
    }
}
