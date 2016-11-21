using Microsoft.VisualStudio.TestTools.UnitTesting;
using RowingAutomation;

namespace RowingTests
{
    [TestClass]
    public class CreateNewCompetition : RowingTest
    {
        [TestMethod]
        public void CanCreateNewCompetition()
        {
            CompetitionListPage.GoTo();
            NewCompetitionPage.GoTo();
            NewCompetitionPage.CreateCompetition("Nowe zawody2").WithDate("12.08.2016").WithDescription("XYZ").Publish();
            CompetitionListPage.GoTo();
            CompetitionListPage.FindAndOpenCompetition("Nowe zawody2").WithDate("12.08.2016").WithDescription("XYZ").Open();

            Assert.AreEqual(CompetitionDetailsPage.CompetitionName, "Nowe zawody2", "Title did not match");
            Assert.AreEqual(CompetitionDetailsPage.CompetitionDate, "2016-08-12", "Date did not match");
            Assert.AreEqual(CompetitionDetailsPage.CompetitionDescription, "XYZ", "Description did not match");

            //cleanup
            CompetitionListPage.GoTo();
            CompetitionListPage.FindAndDeleteCompetition("Nowe zawody2").WithDate("12.08.2016").WithDescription("XYZ").Delete();
        }
    }
}
