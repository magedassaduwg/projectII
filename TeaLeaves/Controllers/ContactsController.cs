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
        public List<User> GetUsersContacts(User user)
        {
            return this._contactsDAL.GetUsersContacts(user);
        }


        /// <summary>
        /// method deleting a contact from a User's contact list in the database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="contact"></param>
        public void RemoveContact(User user, User contact)
        {
            this._contactsDAL.RemoveContact(user, contact);
        }
    }
}
