using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// Message controller is responsible for handling the message flow
    /// </summary>
    public class MessageController
    {
        private MessageDAL _messagesDAL;

        /// <summary>
        /// Constructor to initialize the DAL
        /// </summary>
        public MessageController()
        {
            _messagesDAL = new MessageDAL();
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
        /// Gets a chat history for a group
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="contactId"></param>
        /// <returns></returns>
        public List<IUserMessage> GetMessagesByGroupId(int groupId)
        {
            return _messagesDAL.GetMessagesByGroupId(groupId);
        }

        /// <summary>
        /// Saves a message to the database
        /// </summary>
        /// <param name="message"></param>
        public int SaveMessageToDatabase(IUserMessage message)
        {
            return _messagesDAL.SaveMessage(message);
        }

        public void DeleteMessageFromDatabase(int messageId)
        {
            _messagesDAL.DeleteMessageById(messageId);
        }
    }
}
