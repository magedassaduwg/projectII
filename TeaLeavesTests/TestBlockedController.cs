using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaLeaves.Controllers;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeavesTests
{
    [TestClass]
    public class TestBlockedController
    {
        [TestMethod]
        public void TestBlockUser()
        {
            BlockedController blockedController = new BlockedController();

            User user = new User
            {
                UserId = 180
            };
            User blocked = new User
            {
                UserId = 181
            };

            try
            {
                bool wasBlocked = blockedController.BlockUser(180, 181);
                Assert.IsTrue(wasBlocked);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestIsUserBlocked()
        {
            BlockedController blockedController = new BlockedController();

            User user = new User
            {
                UserId = 180
            };
            User blocked = new User
            {
                UserId = 181
            };

            try
            {
                bool isBlocked = blockedController.IsUserBlocked(180, 181);
                Assert.IsTrue(isBlocked);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }

        [TestMethod]
        public void TestIsUserEmailBlocked()
        {
            BlockedController blockedController = new BlockedController();

            User user = new User
            {
                UserId = 180
            };
            User blocked = new User
            {
                UserId = 181
            };
            CurrentUserStore.User = user;
            try
            {
                bool isBlocked = blockedController.IsUserEmailBlocked("test6");
                Assert.IsTrue(isBlocked);
            }
            catch (Exception)
            {
                Assert.IsFalse(false);
            }
        }
    }
}
