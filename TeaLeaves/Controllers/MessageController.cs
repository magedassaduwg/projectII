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

        /// <summary>
        /// Delete a messsage from the database
        /// </summary>
        /// <param name="messageId"></param>
        public void DeleteMessageFromDatabase(int messageId)
        {
            _messagesDAL.DeleteMessageById(messageId);
        }

        /// <summary>
        /// Saves an image to the database
        /// </summary>
        /// <param name="base64Image"></param>
        /// <returns></returns>
        public int SaveImageToDatabase(string base64Image)
        {
            return _messagesDAL.SaveBase64Image(base64Image);
        }

        /// <summary>
        /// Gets a media file by media id
        /// </summary>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public string GetMediaById(int mediaId)
        {
            return _messagesDAL.GetBase64Media(mediaId);
        }

        /// <summary>
        /// Forwards a message from one contact to another
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="destinationId"></param>
        /// <param name="isGroupMessage"></param>
        public void ForwardMessage(int messageId, int senderId, int destinationId, bool isGroupMessage)
        {
            _messagesDAL.ForwardMessage(messageId, senderId, destinationId, isGroupMessage);
        }
    }
}
