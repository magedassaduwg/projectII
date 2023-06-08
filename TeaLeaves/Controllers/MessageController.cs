using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// Message controller is responsible for handling the message flow
    /// </summary>
    public class MessageController
    {
        private MessagessDAL _messagesDAL;

        /// <summary>
        /// Constructor to initialize the DAL
        /// </summary>
        public MessageController()
        {
            _messagesDAL = new MessagessDAL();
        }

        /// <summary>
        /// Gets a chat history between 2 people
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="contactId"></param>
        /// <returns></returns>
        public List<IUserMessage> GetMessagesByUserId(int userId, int contactId)
        {
            return _messagesDAL.GetMessagesByUserId(userId, contactId);
        }

        /// <summary>
        /// Saves a message to the database
        /// </summary>
        /// <param name="message"></param>
        public void SaveMessageToDatabase(IUserMessage message)
        {
            _messagesDAL.SaveMessage(message);
        }
    }
}
