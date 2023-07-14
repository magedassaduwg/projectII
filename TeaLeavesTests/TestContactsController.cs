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

        [TestMethod]
        public void TestGetUsersContactsByEvents()
        {
            ContactsController contactsController = new ContactsController();
            EventResponseController eventResponseController = new EventResponseController();
            User user = new User
            {
                UserId = 85,
            };
            User userTwo = new User
            {
                UserId = 84,
                Email = "test3"
            };
            Event @event = new Event
            {
                Id = 171,
            };
            EventResponse @eventResponse = new EventResponse
            {
                EventId = 171,
                InviterId = 85,
                ReceiverId = 84
            };
            try
            {
                contactsController.AddContact(user, userTwo.Email);
                eventResponseController.AddEventResponse(@eventResponse);
                var message = contactsController.GetUsersContactsByEvent(user, @event);
                eventResponseController.DeleteEventResponse(84, 171);
                Boolean wasRemoved = contactsController.RemoveContact(user, userTwo);
                Assert.IsTrue(wasRemoved);

                Assert.IsTrue(message.Any());
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestGetUsersContactsNotInvitedByEvent()
        {
            ContactsController contactsController = new ContactsController();
            User user = new User
            {
                UserId = 1
            };
            Event @event = new Event
            {
                Id = 1
            };
            try
            {
                var message = contactsController.GetUsersContactsNotInvitedByEvent(user, @event);
                Assert.IsTrue(message.Any());
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void GetUserContactsBySurvey()
        {
            ContactsController contactsController = new ContactsController();
            User user = new User
            {
                UserId = 24
            };
            Survey survey = new Survey
            {
                Id = 32,
            };
            List<User> users;
            try
            {
                users = contactsController.GetUserContactsBySurvey(user, survey);
                Assert.AreEqual(users[0].UserId, 25);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
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
