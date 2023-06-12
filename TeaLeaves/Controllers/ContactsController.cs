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
        /// method deleting a contact from a User's contact list in the database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="contact"></param>
        public void RemoveContact(Models.User user, User contact)
        {
            this._contactsDAL.RemoveContact(user, contact);
        }

        /// <summary>
        /// method that calls on helper method to check if a email exists. If so, returns true and adds the contact.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public Boolean AddContact(Models.User user, string email)
        {
            return this._contactsDAL.AddContact(user, email);
        }
    }
}
