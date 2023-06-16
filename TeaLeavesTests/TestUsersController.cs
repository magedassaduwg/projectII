
using System.Drawing;
using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    [TestClass]
    public class TestUsersController
    {
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
    }
}
