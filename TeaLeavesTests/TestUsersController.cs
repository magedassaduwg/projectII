using System.Drawing;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    /// <summary>
    /// The test class for the UserController class
    /// </summary>
    [TestClass]
    public class TestUsersController
    {
        /// <summary>
        /// Tests the UploadProfilePicture method
        /// </summary>
        [TestMethod]
        public void TestUploadProfilePicture()
        {
            UsersController controller = new UsersController();

            User user = new User
            {
                UserId = 1,
                ProfilePicture = Image.FromFile("Resources\\user.png")
            };

            try
            {
                Boolean wasUploaded = controller.UploadProfilePicture(user);
                Assert.IsTrue(wasUploaded);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the SetUserBlurb method
        /// </summary>
        [TestMethod]
        public void TestSetUserBlurb()
        {
            UsersController controller = new UsersController();
            User user = new User
            {
                UserId = 1,
                Blurb = "test"
            };
            try
            {
                Assert.IsTrue(controller.SetUserBlurb(user));
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

        }

        /// <summary>
        /// Tests the GetUserBlurb method
        /// </summary>
        [TestMethod]
        public void TestGetUserBlurb()
        {
            UsersController controller = new UsersController();
            User user = new User
            {
                UserId = 1,
                Blurb = "test"
            };
            try
            {
                controller.SetUserBlurb(user);
                Assert.IsTrue(controller.GetUserBlurb(user.UserId) == "test");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the VerifyUserCredentials method
        /// </summary>
        [TestMethod]
        public void TestVerifyUserCredentials()
        {
            UsersController controller = new UsersController();

            User user = new User
            {
                UserId = 1,
                Username = "test",
                Password = EncryptionHelper.EncryptString("test"),
        };

            try
            {
                User testUser = controller.VerifyUserCredentials(user);
                Assert.IsNotNull(testUser);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the Add and Delete methods
        /// </summary>
        [TestMethod]
        public void TestAddUserAndDeleteUser()
        {
            UsersController controller = new UsersController();
            User user = new User
            {
                Username = "test5",
                Password = EncryptionHelper.EncryptString("test"),
                FirstName = "test",
                LastName = "test",
                Email = "test5",
            };

            try
            {
                int userId = controller.Add(user);
                Assert.AreNotEqual(userId, 0);

                controller.Delete(userId);
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        /// <summary>
        /// Tests the GetUserById method
        /// </summary>
        [TestMethod]
        public void TestGetUserById()
        {
            UsersController controller = new UsersController();

            try
            {
                User user = controller.GetUserById(24);
                Assert.AreEqual(user.Username, "test");
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestGetUserStats()
        {
            UsersController controller = new UsersController();
            double[] userStats = controller.GetUserStats(23);
            try
            {
                Assert.IsTrue(userStats[0] == 50);
                Assert.IsTrue(userStats[1] == 4);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
