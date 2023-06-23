using System.Data.SqlClient;
using TeaLeaves.DALs;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// controller class to work with Contacts represented by Users objects
    /// </summary>
    public class ContactsController
    {
        private ContactsDAL _contactsDAL;

        /// <summary>
        /// contructor to create the controller
        /// </summary>
        public ContactsController()
        {
            this._contactsDAL = new ContactsDAL();
        }

        /// <summary>
        /// method to retrieve a list of a user's contacts represented by a list of Users objects
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> GetUsersContacts(Models.User user)
        {
            return this._contactsDAL.GetUsersContacts(user);
        }

        /// <summary>
        /// Returns a users contacts sorted by last message recevied from the contact
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<User> GetMessageContacts(User user)
        {
            return _contactsDAL.GetMessageContacts(user);
        }

        /// <summary>
        /// Returns the users who have been invited to an event
        /// </summary>
        /// <param name="user"></param>
        /// <param name="event"></param>
        /// <returns></returns>
        public List<User> GetUsersContactsByEvent(Models.User user, Event @event)
        {
            return _contactsDAL.GetUsersContactsByEvent(user, @event);
        }


        /// <summary>
        /// Returns the users who have not been invited to an event
        /// </summary>
        /// <param name="user"></param>
        /// <param name="event"></param>
        /// <returns></returns>
        public List<User> GetUsersContactsNotInvitedByEvent(Models.User user, Event @event)
        {
            return _contactsDAL.GetUsersContactsNotInvitedByEvent(user, @event);
        }

        /// <summary>
        /// method deleting a contact from a User's contact list in the database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="contact"></param>
        public Boolean RemoveContact(Models.User user, User contact)
        {
            return this._contactsDAL.RemoveContact(user, contact);
        }

        /// <summary>
        /// method that calls on helper method to check if a email exists. If so, returns true and adds the contact.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool AddContact(Models.User user, string email)
        {
            return this._contactsDAL.AddContact(user, email);
        }
    }
}
