using Microsoft.VisualStudio.TestTools.UnitTesting;
using RowingAutomation;

namespace RowingTests
{
    public class RowingTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.GoTo();
            LoginPage.LoginAs("geralt0001").WithPassword("Koalicja1").Login();
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
