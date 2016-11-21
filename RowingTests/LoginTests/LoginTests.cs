using Microsoft.VisualStudio.TestTools.UnitTesting;
using RowingAutomation;

namespace RowingTests
{
    [TestClass]
    public class LoginTests : RowingTest
    {
        [TestMethod]
        public void AdminUserCanLogin()
        {
            Assert.IsTrue(HomePage.IsAt, "Failed to login");
        }
    }
}
