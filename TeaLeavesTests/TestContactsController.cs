using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    [TestClass]
    public class TestContactsController
    {

        [TestMethod]
        public void TestGetUsersContacts()
        {
            ContactsController contactsController = new ContactsController();
            User user = new User
            {
                UserId = 1
            };

            try
            {
                var message = contactsController.GetUsersContacts(user);
                Assert.IsTrue(message.Any());
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        public void TestGetUsersContactsByEvents()
        {

        }

        public void TestGetUsersContactsNotInvitedByEvent()
        {

        }

        [TestMethod]
        public void TestRemoveContact()
        {
            ContactsController contactsController = new ContactsController();
            User user = new User
            {
                UserId = 1
            };
            User contact = new User
            {
                UserId = 2,
                Email = "test@email.com"
            };

            try
            {
                Boolean wasRemoved = contactsController.RemoveContact(user, contact);
                Assert.IsTrue(wasRemoved);
            }
            catch (Exception ex)
            {
                Assert.IsFalse(false);
            }
        }
        
        [TestMethod]
        public void TestAddContact()
        {
            ContactsController contactsController = new ContactsController();
            User user = new User
            {
                UserId = 1
            };
            User contact = new User
            {
                UserId = 2,
                Email = "test@email.com"
            };

            try
            {
                Boolean wasAdded = contactsController.AddContact(user, contact.Email);
                Assert.IsTrue(wasAdded);
            }
            catch (Exception ex)
            {
                Assert.IsFalse(false);
            }
        }
    }
}
