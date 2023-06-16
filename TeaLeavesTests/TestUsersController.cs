
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
                ProfilePicture = Image.FromFile("Resources\\user.png")
            };

            Boolean wasUploaded = controller.UploadProfilePicture(user);
            try
            {
                Assert.IsTrue(wasUploaded);
            }

            catch (Exception ex)
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
                Blurb = "test"
            };
            controller.SetUserBlurb(user);
            try
            {
                Assert.IsTrue(controller.GetUserBlurb(user.UserId) == "test");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
